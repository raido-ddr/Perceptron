using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        public int ClusterCount { get; set; }

        public int FeatureCount { get; set; }

        private Cluster[] Clusters { get; set; }

        public Perceptron(int clusterCount, int featureCount)
        {
            ClusterCount = clusterCount;
            FeatureCount = featureCount;
            InitializeClusters();
        }

        public bool Train(ImageSet trainingSet, int iterationLimit)
        {
            bool punishmentNeeded = false;

            for (int i = 0; i < iterationLimit; i++)
            {
                punishmentNeeded = TrainingIteration(trainingSet);
                if (! punishmentNeeded)
                {
                    break;
                }
            }

            bool trainingSucceeded = punishmentNeeded
                ? false
                : true;

            return trainingSucceeded;
        }

        private bool TrainingIteration(ImageSet trainingSet)
        {
            bool needsPunishment = false;
            ClearClusters();

            for (int i = 0; i < trainingSet.Size; i++)
            {
                ImageVector currentVector = trainingSet[i];
                int predictedClusterCode = Classify(currentVector);
                AssignCluster(currentVector, predictedClusterCode);

                if (currentVector.ClusterCode != predictedClusterCode)
                {
                    ApplyPunishment(currentVector);
                    needsPunishment = true;
                }

            }

            return needsPunishment;
        }

        private void ClearClusters()
        {
            foreach (var cluster in Clusters)
            {
                cluster.ClearImageVectors();
            }
        }

        private void AssignCluster(ImageVector vector, int clusterCode)
        {
            Clusters[clusterCode].AddImageVector(vector);
        }

        private int Classify(ImageVector currentVector)
        {
            int maxPredictionValue = int.MinValue;
            int predictedClusterCode = 0;

            for(int i = 0; i < ClusterCount; i++)
            {
                int prediction = Clusters[i].PredictorFunction(currentVector);

                if (prediction > maxPredictionValue)
                {
                    maxPredictionValue = prediction;
                    predictedClusterCode = i;
                }
            }

            return predictedClusterCode;
        }

        private void ApplyPunishment(ImageVector currentVector)
        {
            for (int i = 0; i < ClusterCount; i++)
            {
                if (i == currentVector.ClusterCode)
                {
                    Clusters[i].IncreaseWeight(currentVector);
                }
                else
                {
                    Clusters[i].DecreaseWeight(currentVector);
                }
            }
        }

        private void InitializeClusters()
        {
            for (int i = 0; i < ClusterCount; i++)
            {
                Clusters[i] = new Cluster(i, FeatureCount);
            }
        }

    }
}

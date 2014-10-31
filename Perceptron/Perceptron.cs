using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        public int ClusterCount
        {
            get { return Clusters.Length; }
        }

        public int FeatureCount { get; set; }

        public static Perceptron Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Perceptron();
                }
                return instance;
            }
        }

        private Cluster[] Clusters { get; set; }

        private static Perceptron instance;
        
        private Perceptron()
        {}

        public void LoadTrainingSet(ImageSet trainingSet)
        {
            Clusters = trainingSet.Clusters;
        }

        public void Reset()
        {
            ClearClusters();
        }


        public bool Train(ImageSet trainingSet, int iterationLimit)
        {
            bool punishmentNeeded = false;
            int iterationCount = 0;

            for (iterationCount = 0; iterationCount < iterationLimit; iterationCount++)
            {
                punishmentNeeded = TrainingIteration();
                if (! punishmentNeeded)
                {
                    break;
                }
            }

            Console.WriteLine(iterationCount);

            bool trainingSucceeded = punishmentNeeded
                ? false
                : true;

            return trainingSucceeded;
        }

        public int Classify(ImageVector image)
        {
            int maxPredictionValue = int.MinValue;
            int predictedClusterCode = 0;

            for (int i = 0; i < ClusterCount; i++)
            {
                int prediction = Clusters[i].PredictorFunction(image);

                if (prediction > maxPredictionValue)
                {
                    maxPredictionValue = prediction;
                    predictedClusterCode = i;
                }
            }

            return predictedClusterCode;
        }

        private bool TrainingIteration()
        {
            bool punishmentApplied = false;

            for (int i = 0; i < ClusterCount; i++)
            {
                bool clusterPunishmentApplied = TrainOnCluster(Clusters[i]);
                if (clusterPunishmentApplied)
                {
                    punishmentApplied = true;
                }
            }

            return punishmentApplied;
        }

        private bool TrainOnCluster(Cluster cluster)
        {
            bool punishmentApplied = false;

            for (int j = 0; j < cluster.ImageVectorCount; j++)
            {
                ImageVector currentImage = cluster[j];
                int trainingPrediction = cluster.PredictorFunction(currentImage);

                foreach (var otherCluster in Clusters)
                {
                    int otherPrediction = otherCluster.PredictorFunction(currentImage);
                    if ((otherPrediction >= trainingPrediction) 
                        && (otherCluster != cluster))
                    {
                        ApplyPunishment(cluster, currentImage);
                        punishmentApplied = true;
                        break;
                    }
                }
               
            }

            return punishmentApplied;
        }
       
       
        

        private void ApplyPunishment(Cluster clusterToIncrease, ImageVector currentVector)
        {
            foreach (Cluster cluster in Clusters)
            {
                if (cluster == clusterToIncrease)
                {
                    cluster.IncreaseWeight(currentVector);
                }
                else
                {
                    cluster.DecreaseWeight(currentVector);
                }
            }
        }

        private void ClearClusters()
        {
            foreach (var cluster in Clusters)
            {
                cluster.ClearImageVectors();
            }
        }


        private void InitializeClusters()
        {
            for (int i = 0; i < ClusterCount; i++)
            {
                Clusters[i] = new Cluster(i, FeatureCount);
            }
        }

        public  string ClustersToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cluster cluster in Clusters)
            {
                sb.Append(cluster.ToString());
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        public string PredictorFunctionsToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cluster cluster in Clusters)
            {
                sb.Append(cluster.PredictorFunctionString());
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();

        }


    }
}

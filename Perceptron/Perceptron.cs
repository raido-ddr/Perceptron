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

        private Cluster[] Clusters { get; set; };

        public Perceptron(int clusterCount, int featureCount)
        {
            ClusterCount = clusterCount;
            FeatureCount = featureCount;
            InitializeClusters();
        }

        public void Train(ImageSet trainingSet, int iterationLimit)
        {
            
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevAge.Drawing.VisualElements;

namespace Perceptron
{
    class ImageSetGenerator
    {
        public static ImageSetGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImageSetGenerator();
                }
                return instance;
            }
        }

        private static ImageSetGenerator instance;

        private static Random random = new Random();

        private ImageSetGenerator()
        {}

        public ImageSet GenerateRandomSet(int clusterCount, int imagesPerCluster,
            int featureCount)
        {
            ImageSet imageSet = new ImageSet(clusterCount);

            for (int i = 0; i < clusterCount; i++)
            {
                imageSet[i] = GenerateRandomCluster(i,
                    imagesPerCluster, featureCount);
            }

            return imageSet;
        }

        private Cluster GenerateRandomCluster(int code, int vectorCount, int featureCount)
        {
            Cluster cluster =  new Cluster(code, featureCount + 1);

            for (int i = 0; i < vectorCount; i++)
            {
                ImageVector image = GenerateRandomVector(featureCount);
                cluster.AddImageVector(image);
            }

            return cluster;
        }

        private ImageVector GenerateRandomVector(int featureCount)
        {
            ImageVector image = new ImageVector(featureCount + 1);

            for (int i = 0; i < featureCount; i++)
            {
                image[i] = random.Next(-20, 21);
            }

            image[featureCount] = 1;

            return image;
        }
    }
}

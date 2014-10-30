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
        public ImageSet GenerateRandomSet(int clusterCount, int imagesPerCluster,
            int vectorDimension)
        {
            int imageCount = clusterCount * imagesPerCluster;

            ImageSet imageSet = new ImageSet(imageCount);

            for (int i = 0; i < clusterCount * imagesPerCluster; i++)
            {
                imageSet[i] = GenerateRandomVector(clusterCount, vectorDimension);
            }

            return imageSet;
        }

        private ImageVector GenerateRandomVector(int clusterCount, int vectorDimension)
        {
            ImageVector image = new ImageVector(vectorDimension);
            Random rnd = new Random();

            for (int i = 0; i < vectorDimension; i++)
            {
                image[i] = rnd.Next(-10, 11);
                image.ClusterCode = rnd.Next(clusterCount) + 1;
            }

            return image;
        }
    }
}

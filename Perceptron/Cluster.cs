using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Cluster
    {
        public int Code { get; set; }

        private Vector Weight { get; set; }

        public Cluster(int code, int featureCount)
        {
            Code = code;
            Weight = new Vector(featureCount);
        }

        public int PredictorFunction(Vector vector)
        {
            int product = 0;
            for (int i = 0; i < Weight.Dimension; i++)
            {
                product += Weight[i] * vector[i];
            }

            return product;
        }

        public void IncreaseWeight(Vector vector)
        {
            for (int i = 0; i < Weight.Dimension; i++)
            {
                Weight[i] += vector[i];
            }
        }

        public void DecreaseWeight(int[] vector)
        {
            for (int i = 0; i < Weight.Dimension; i++)
            {
                Weight[i] -= vector[i];
            }
        }
        



    }
}

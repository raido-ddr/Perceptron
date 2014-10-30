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

        public List<ImageVector> ImageVectors { get; set; }

        private Vector Weight { get; set; }
        
        public Cluster(int code, int featureCount)
        {
            Code = code;
            Weight = new Vector(featureCount);
            ImageVectors = new List<ImageVector>();
        }

        public void AddImageVector(ImageVector imageVector)
        {
            ImageVectors.Add(imageVector);
        }

        public void ClearImageVectors()
        {
            ImageVectors.Clear();
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

        public void DecreaseWeight(Vector vector)
        {
            for (int i = 0; i < Weight.Dimension; i++)
            {
                Weight[i] -= vector[i];
            }
        }

        public string PredictorFunctionString()
        {
            StringBuilder sb = new StringBuilder();
            int dimension = Weight.Dimension;

            for (int i = 0; i < dimension; i++)
            {
                sb.Append(Weight[i])
                    .Append("x")
                    .Append(i);

                if (i < (dimension - 1))
                {
                    sb.Append(" + ");
                }
            }

            return sb.ToString();
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Class #").Append(Code).Append("line");

            foreach (ImageVector iv in ImageVectors)
            {
                sb.Append(iv.ToString());
            }

            return sb.ToString();
        }



    }
}

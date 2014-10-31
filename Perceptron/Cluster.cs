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

        public int ImageVectorCount
        {
            get { return ImageVectors.Count;  }
        }

        public ImageVector this[int index]
        {
            get { return ImageVectors[index];  }
            set { ImageVectors[index] = value;  }
        }

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

            sb.Append("D");
            sb.Append(Code);
            sb.Append("(x) = ");

            for (int i = 0; i < dimension; i++)
            {
                sb.Append(Weight[i].ToString("+#;-#;+0"));

                if (i < (dimension - 1))
                {
                    sb.Append(" x").Append(i).Append(" ");
                }
            }

            return sb.ToString();
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Class #").Append(Code).Append(Environment.NewLine);

            for (int i = 0; i < ImageVectorCount; i++)
            {
                sb.Append(ImageVectors[i].ToString());
                if (i < (ImageVectorCount - 1))
                {
                    sb.Append(", ");
                }
                else
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }



    }
}

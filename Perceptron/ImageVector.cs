using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class ImageVector : Vector
    {

        public ImageVector(int dimension)
            : base(dimension)
        {}

        public ImageVector(string[] features)
            : base(features.Length)
        {
            for (int i = 0; i < features.Length; i++)
            {
                Values[i] = Convert.ToInt32(features[i]);
            }
        }
        
    }
}

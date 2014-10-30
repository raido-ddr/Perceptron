using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class ImageVector : Vector
    {

        public int ClusterCode { get; set; }

        public ImageVector(int dimension)
            : base(dimension)
        {}
        
    }
}

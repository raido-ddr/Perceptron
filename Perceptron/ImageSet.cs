using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class ImageSet
    {
        public ImageVector[] vectors { get; set; }

        public int Size 
        {
            get { return vectors.Length; }
        }

        public ImageSet(int vectorCount)
        {
            vectors = new ImageVector[vectorCount];
        }

        public ImageVector this[int index]
        {
            get { return vectors[index]; }
            set { vectors[index] = value; }
        }

    }
}

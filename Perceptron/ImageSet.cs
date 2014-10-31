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
        public Cluster[] Clusters { get; set; }

        public int Size 
        {
            get { return Clusters.Length; }
        }

        public ImageSet(int vectorCount)
        {
            Clusters = new Cluster[vectorCount];
        }

        public Cluster this[int index]
        {
            get { return Clusters[index]; }
            set { Clusters[index] = value; }
        }

    }
}

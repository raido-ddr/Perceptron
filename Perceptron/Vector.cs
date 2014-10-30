using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Vector
    {
        public Vector(int dimension)
        {
            Values = new int[dimension];
        }

        public int[] Values { get; set; }

        public int Dimension
        {
            get { return Values.Length; }
        }

        public int this[int index]
        {
            get { return Values[index]; }
            set { Values[index] = value;  }
        }
    }
}

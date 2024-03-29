﻿using System;
using System.Collections.Generic;
using System.Configuration;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            for (int i = 0; i < Values.Length - 1; i++)
            {
                sb.Append(Values[i]);

                if (i < (Values.Length - 2))
                {
                    sb.Append(", ");
                }
            }

            sb.Append(")");
            return sb.ToString();
        }

        public void Supplement(int extraFeature)
        {
            int [] supplementedValues = new int[Values.Length + 1];

            for (int i = 0; i < Values.Length; i++)
            {
                supplementedValues[i] = Values[i];
            }

            supplementedValues[Values.Length] = extraFeature;
            Values = supplementedValues;
        }
    }
}

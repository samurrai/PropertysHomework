using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertysHomework
{
    public class UniversalArray
    {
        private int[] arr;

        public UniversalArray(int size)
        {
            arr = new int[size];
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < arr.Length)
                {
                    return arr[i];
                }
                return arr[0];
            }

            set
            {
                if (i > 0 && i < arr.Length)
                {
                    arr[i] = value * value;
                }
            }
        }
    }
}
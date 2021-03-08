using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingApp.BoobleSort
{
    public class BoobleIntSort : IBoobleIntSort
    {
        public int[] Sort(int[] array)
        {
            if (array.Length == 0)
                return array;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }

            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_6_3
{
    static class ExtensionArray
    {
        static public void SortArray(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
        }
    }
}

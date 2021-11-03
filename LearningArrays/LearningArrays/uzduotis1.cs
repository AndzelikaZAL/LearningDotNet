using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class uzduotis1
    {
        static void Main (string[] args)
        {
            int[] values = new int[20];

            values[0] = 1;
            values[1] = 2;
            values[2] = 3;
            values[3] = 4;
            values[4] = 5;
            values[5] = 6;
            values[6] = 7;
            values[7] = 8;
            values[8] = 9;
            values[9] = 10;
            values[10] = 11;
            values[11] = 12;
            values[12] = 13;
            values[13] = 14;
            values[14] = 15;
            values[15] = 16;
            values[16] = 17;
            values[17] = 18;
            values[18] = 19;
            values[19] = 20;

            Array.Reverse(values);

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class uzduotis2
    {
        
        static void CarList(string[] args)
        {
            string[] cars;

            cars = new string[5];
            cars[0] = "Mazda";
            cars[1] = "Peugeot";
            cars[2] = "Volvo";
            cars[3] = "Audi";
            cars[4] = "Arklys";


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadLine();
        }

    }

}
           
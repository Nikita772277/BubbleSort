using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Work
    {
        public int[] SetArray()
        {
            Console.WriteLine($"Введите сколько чисел вы хотите записать в массив");
            string numberEnter = Console.ReadLine();
            bool check = int.TryParse(numberEnter, out int result);
            int[] ints = new int[result];
            for (int i = 0; i < result; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                string enter = Console.ReadLine();
                bool checkEnter = int.TryParse(enter, out var enterResult);

                ints[i] = enterResult;
            }
            return ints;
        }
        public int[] SortingArray(int[] ints)
        {           
            for (int i = 0; i < ints.Length; i++)
            {
                int number;
                for (int j = 0; j < ints.Length-1-i; j++)
                {               
                    if (ints[j] > ints[j+1])
                    {
                        number = ints[j];                        
                        ints[j] = ints[j+1];
                        ints[j + 1] = number;           
                    }
                }            
            }           
            return ints;
        }       
    }
}

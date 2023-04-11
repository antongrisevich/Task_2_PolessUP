using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolessUP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 2

            int[] nums = new int[] { 1, 5, 3, 9, 4, 6};
            int target = 11;
            for(int i = 0; i< nums.Length; i++)
            {
                for(int j = i+1; j< nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"Индексы чисел, которые в сумме дают число {target} : [{i},{j}]");
                        break;
                    }
                  
                }
            }
        }
    }
}

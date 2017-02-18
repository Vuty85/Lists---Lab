using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] ==nums[i-1])
                {
                    nums[i-1]=nums[i-1]*2;
                    nums.RemoveAt(i);

                    if (i != 1) i = i - 2;
                    else i--;
     
                 
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

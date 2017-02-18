using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squareNum = new List<int>();

            foreach (int  num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num)) squareNum.Add(num);
                
            }
            squareNum.Sort();
            squareNum.Reverse();

            Console.WriteLine(String.Join(" ", squareNum));
        }

    }
}

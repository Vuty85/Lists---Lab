using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            for (int i = n.Count; i > 0; i--)
            {
                if (n[i-1] >= 0)
                {
                    result.Add(n[i-1]);
                }
              
            }
            if (result.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
           
        }
    }
}

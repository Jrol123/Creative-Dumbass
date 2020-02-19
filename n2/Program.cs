using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2
{
    class Program
    {
        static void Num2(int a,out List<int> num)
        {
            List<int> lol = new List<int> { };
            num = lol;
            while (a !> 0)
            {
                num.Add(a % 2);
                a /= 2;
            }
           
        }
        static void Main(string[] args)
        {
            int num = 1;
            while(num != 0)
            {
                num = int.Parse(Console.ReadLine());
                Num2(num, out List<int> numE);
                for (int i = numE.Count - 1; i > 0; i--)
                {
                    Console.WriteLine(numE[i]);
                }
            }
            
        }
    }
}

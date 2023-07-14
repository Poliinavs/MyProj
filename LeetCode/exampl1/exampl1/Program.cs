using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadLine();

            int[] ints = { 3, 3 };
            int target = 6;
            for (int i=0; i<ints.Length-1; i++)
            {
                for (int j=i+1; j<ints.Length; j++) {
                    if (ints[i] + ints[j]==target)
                    {
                        Console.WriteLine(i+" "+" "+j);
                        return;

                    }
                }

            }

        }
    }
}
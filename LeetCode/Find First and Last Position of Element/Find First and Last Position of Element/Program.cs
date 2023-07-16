using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int BinarySearch(int[] mas, int search, int first, int last )
        {
            int rez = -1;
            if (first>=last)
            {
                if (first> mas.Length-1) {
                    return -1;
                }
                if (mas[first] == search)
                    return first;
                return -1;
            }
            var center = (last + first) / 2;
            if (mas[center]==search)
            {
                return center;
            }
            if (mas[center]<search)
            {
               rez= BinarySearch(mas, search, center+1, last);
            }
            if (mas[center] > search)
            {
              rez=  BinarySearch(mas, search, first, center-1);
            }
            return rez;
         
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1,-1};
            if (nums.Length == 0)
            {
  
                return result;
            }


           int center= BinarySearch(nums, target, 0, nums.Length);
            if (center != -1)
            {
                result[0] = center;
                result[1] = center;
                int right = BinarySearch(nums, target, center , nums.Length);
                int left = BinarySearch(nums, target, 0, center);
                if (left != -1)
                {
                    result[0] = left;
                } 
                if (right!=-1) {
                  
                    result[1] = right;
                }
             
            }
         
               
           

          
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = {2,2 };
            int target = 3;
            int[] ints = SearchRange(nums, target);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantidadDeNumerosMenores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [8, 1, 2, 2, 3];

            SmallerNumbersThanCurrent(nums);
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] CantidadMenor = new int[nums.Length];

            for(int i = 0;i <  nums.Length;i++)
            {
                for(int j = 0;j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        CantidadMenor[i] += 1;
                    }
                }
            }
            return CantidadMenor;
        }
    }
}
/*
            foreach(int i in CantidadMenor)
            {
                Console.WriteLine(i);
            }*/
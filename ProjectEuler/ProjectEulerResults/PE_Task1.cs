using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerResults
{
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    //The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.

    public class PE_Task1
    {
        private int p_MaxValue;
        private int[] p_DivisorValues;
        private int p_SumOfMultiples;

        public static void Main()
        {
            //int[] numbers = new int[] { 3, 5 };
            //PE_Task1 T1 = new PE_Task1(1000, numbers);
            //T1.GenerateSumOfMultiples();
            //Console.WriteLine(T1.SumOfMultiples);
        }

        public PE_Task1(int maxValue, params int[] divisors)
        {
            p_MaxValue = maxValue;
            p_DivisorValues = divisors;
        }
        
        public void GenerateSumOfMultiples()
        {
            for (int i = 0; i < p_MaxValue; i++)
            {
                for (int j = 0; j < p_DivisorValues.Length; j++)
                {
                    if (i % p_DivisorValues[j] == 0)
                    {
                        p_SumOfMultiples += i;
                        /*If it finds one, BREAK OUT, otherwise it may add it to the total multiple
                        times e.g. 15 is a multiple of 3 and 5 - hence incorrect answer!!*/
                        break;
                    }
                }
            }
        }

        public int SumOfMultiples
        {
            get { return p_SumOfMultiples; }
        }
    }
}

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
        private int p_Divisor;
        private int p_SumOfMultiples;

        public static void Main()
        {
            //PE_Task1 T1 = new PE_Task1(10, 3);
            //T1.GetSumOfMultiples();
            //Console.WriteLine(T1.MultipleSum);
        }

        public PE_Task1(int maxValue, int divisor)
        {
            p_MaxValue = maxValue;
            p_Divisor = divisor;
        }
        
        public void GenerateSumOfMultiples()
        {
            for (int i = 0; i <= p_MaxValue; i++)
            {
                if (i % p_Divisor == 0)
                {
                    p_SumOfMultiples += i;
                }
            }
        }

        public int SumOfMultiples
        {
            get { return p_SumOfMultiples; }
        }


        //private int p_MaxValue;
        //private double p_Multiples;

        //public PE_Task1(int maxValue)
        //{
        //    p_MaxValue = maxValue;
        //}

        //public double Multiples
        //{
        //    get { return p_Multiples; }
        //}

        //public void GetMultiplesOf(int multiple)
        //{
        //    p_Multiples = p_MaxValue / multiple;
        //}

        //public static void Main()
        //{
        //    //PE_Task1 T1 = new PE_Task1(1000);
        //    //T1.GetMultiplesOf(5);
        //}
    }
}

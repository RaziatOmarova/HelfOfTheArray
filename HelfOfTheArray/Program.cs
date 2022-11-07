using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelfOfTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[8] { 5, 2, 3, 9, 1, 6, 7, 8 };
            Console.WriteLine(Quantity(number));
            Console.ReadKey();
        }
        static int Quantity(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length/2; i++)
            {
                if(temp > arr[i])
                {
                    temp = arr[i];
                    arr[i] = i;
                }
            }
            return temp;
        }
    }
}

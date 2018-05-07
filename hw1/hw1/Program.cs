using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 1, 5, 5, 2, 5, 9, 7, 8, 4, 12 };
            int element = 0;
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                int tempElement = arr[i];
                int tempCount = 0;
                for (int j = 0; j < arr.Length; j++)
                    if (arr[j] == tempElement)
                        tempCount++;

                if (tempCount > count)
                {
                    element = tempElement;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequence element is: "+element+". freq: "+count+" times.");
            Console.ReadKey();
        }
    }
}


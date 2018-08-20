using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SortClass
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Enter the number of elements in the array to sort...");
            bool isInt = int.TryParse(Console.ReadLine(), out i);

            while (!isInt)
            {
                Console.WriteLine("Hmm... You must enter a valid integer value. Try again.");
                isInt = int.TryParse(Console.ReadLine(), out i);

            }

            int[] intArr = new int[i];
            Console.WriteLine("Enter the elements of the array one by one");
            int j = 0;
            while (j < i)
            {
                bool isArrayElementInt = int.TryParse(Console.ReadLine(), out intArr[j]);
                if (!isArrayElementInt)
                {
                    Console.WriteLine("Try again. The value is not int");
                }
                else
                {
                    j++;
                    //Console.WriteLine("Enter the next element");
                }
            }

            int k = intArr.Length;
            Console.WriteLine("Before sort the array is:");
            while (k > 0)
            {

                Console.Write($"{intArr[k - 1]} ");
                k--;

            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }


    }

}

using System;

namespace Assigment_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 33, 34, 78, 90, 89, 23, 88, 12, 100, 89, 99, 46, 20, 31 };

            int i, j, temp;
                for (i = 0; i < array.Length; i++)
                {
                    for (j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            Console.Write("\nDescending order:\n");
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            
        }
        }
    }

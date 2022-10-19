using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)

        {
            string put;
            for (int i = 1; i<= 100; i++)

                 {
                put = i.ToString();
                if (i % 3 == 0)
                {
                    put = "Fizz";
                }
               else if (i % 5 == 0)
                {
                    put = "Buzz";
                }
                if (i % 3 == 0 && i % 5 ==0)
                {
                    put = "Buzz Fizz";
                }


                Console.WriteLine(put);
            }  

        }
    }
}


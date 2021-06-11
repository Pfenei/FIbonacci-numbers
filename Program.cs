using System;

namespace FIbonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int f0 = 0;
              int f1 = 1;

              Console.WriteLine("How many outputs would you like to have?");
              int input = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine(f0);
              Console.WriteLine(f1);

              for (int i = 0; i< input; i++)
              {
                  int fn = f0 + f1;
                  Console.WriteLine(fn);
                  f0 = f1;
                  f1 = fn;
              }*/

            /*Console.WriteLine("input?");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int n = 0; n<input;n++)
            {

                for (int i = 1; i < input+1; i++)
                {
                    Console.Write(i);  
                }
                
                for (int k = input; k > 0; k--)
                {
                    Console.Write(k);
                }
                Console.Write("\n");
            }*/
            Console.WriteLine("input?");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            for (int row= 0; row<numberInput;row++)
            {
                for (int col = 0;col<numberInput;col++)
                {
                    int output = col + row + 1;
                    
                    if (output>numberInput)
                    {
                        output = numberInput * 2 - output;
                    }
                    Console.Write(output);
                }
                Console.WriteLine("");
            }
        }
    }
}

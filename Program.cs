using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience you have");
             try
            {   
             
                int value_of_input = int.Parse(Console.ReadLine());
                    
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("you have {0} years of experience",value_of_input );
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
}

using System;

namespace DaysOfLeaveISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
          try
            {
                Console.WriteLine("Hello, how many days of leave do you wish to have off of work?");
                int days = int.Parse(Console.ReadLine());
                if (days < 1 && days < 8)
                {
                    Console.WriteLine("This request is Denied.");
                }
                else
                {
                    Console.WriteLine("Approved for days of leave.");
                }
                Console.WriteLine("Thank you for entering your information");
            }
            catch
            {
                Console.WriteLine("Unsuspected Error");
            }

                  
            
        }
    }
}

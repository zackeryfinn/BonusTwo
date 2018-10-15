using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusTwo
{
    class Program
    {
        static void Main(string[] args)
        {
           //being the y/n repeat loop here             
            while (true)
            {
                DateTime birthDate;
            
                //Greeting and intro to program
                Console.WriteLine("Ever wonder how old you are? Enter your birthdate to find out!");
                Console.Write("Please use the format M/D/YYYY (ex. 10/2/1984): ");


                //getting the date input in m/d/yy format
                string inputBirthDate = Console.ReadLine();
                while (!DateTime.TryParseExact(inputBirthDate, "M/d/yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
                {
                    Console.Write("Invalid format, please retry: ");
                    inputBirthDate = Console.ReadLine();
                }


                //pulling today's date and doing some math
                DateTime today = DateTime.Today;
                TimeSpan span = (today - birthDate);
                int age = (span.Days / 365);
                Console.WriteLine($"You are {age} years old! Now you know.");
                Console.WriteLine();

                //Writing a special message if today's yr bday
                var currentMonth = today.Month;
                var currentDay = today.Day;
                var birthMonth = birthDate.Month;
                var birthDay = birthDate.Day;

                if (currentDay == birthDay && currentMonth == birthMonth)
                {
                    Console.WriteLine("More great news: Today is your birthday!");
                    Console.WriteLine("Just letting you know in case you were unaware.");
                    Console.WriteLine();
                }

                

                //time to see if you want to go again
                Console.Write("Would you like to try again ? If not, please press \"n\" to exit.");
                if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;
                Console.WriteLine();











            }




        }
    }
}

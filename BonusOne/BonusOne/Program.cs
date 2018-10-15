using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //start of loop for go again querry

            while (true)
            {

                //Greeting and introductions
               // Console.WriteLine();
                Console.WriteLine("Welcome to the Letter Grade Converter");
                Console.Write("Please enter a numerical grade: ");


                //Take and validate input for the numerical grade

                float numericalGrade;

                while (!float.TryParse(Console.ReadLine(), result: out numericalGrade) || numericalGrade < 0 || numericalGrade > 100)
                {
                    Console.Write("Sorry, that is not a valid input. Please try again: ");
                }

                Console.WriteLine();

                // Many nested if - else statements to get +/- letter grades
                if (numericalGrade >= 97)
                {
                    Console.WriteLine("Letter grade: A+");
                }
                else
                {
                    if (numericalGrade >= 93)
                    {
                        Console.WriteLine("Letter grade: A");
                    }
                    else
                    {
                        if (numericalGrade >= 88)
                        {
                            Console.WriteLine("Letter grade: A-");
                        }
                        else
                        { if (numericalGrade >= 86)
                            {
                                Console.WriteLine("Letter grade: B+");
                            }
                        else
                            { if (numericalGrade >= 83)
                                {
                                    Console.WriteLine("Letter grade: B");
                                }
                                else
                                {
                                    if (numericalGrade >= 80)
                                    {
                                        Console.WriteLine("Letter grade: B-");
                                    }
                                    else
                                    {
                                        if (numericalGrade >= 76)
                                        {
                                            Console.WriteLine("Letter grade: C+");
                                        }
                                        else
                                        {
                                            if (numericalGrade >= 71)
                                            {
                                                Console.WriteLine("Letter grade: C");
                                            }
                                            else
                                            {
                                                if (numericalGrade >= 67)
                                                {
                                                    Console.WriteLine("Letter grade: C-");
                                                }
                                                else
                                                {
                                                    if (numericalGrade >= 66)
                                                    {
                                                        Console.WriteLine("Letter grade: D+");
                                                    }
                                                    else
                                                    {
                                                        if (numericalGrade >= 63)
                                                        {
                                                            Console.WriteLine("Letter grade: D");
                                                        }
                                                        else
                                                        {
                                                            if (numericalGrade >= 61)
                                                            {
                                                                Console.WriteLine("Letter grade: D-");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Letter grade: F");
                                                            }
                                                        }
                                                    }
                                                }
                                                
                                            }
                                        }
                                    }
                                }
                            }
                            
                        }
                    }

                }

                //Section to go again
               Console.WriteLine();

                Console.Write("Would you like to try again ? If no press \"n\" to exit. -");
                if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;
                Console.WriteLine();
            }
        }
    }
}

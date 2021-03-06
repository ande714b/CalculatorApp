﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using CalculatorLibrary;

namespace CalculatorApp
{
    class Bindings : IBindings
    {

        private double[] ArrayInput()
        {
            bool end = false;  
            double[] numbers = new double[20];
            int i = 0;
            while (!end)
            {
                string tal = Console.ReadLine();

                if (tal == "")
                {
                    Array.Resize(ref numbers, i);
                    end = true;
                }

                else if (i > 19)
                {

                    end = true;
                }

                else
                {
                    if (Double.TryParse(tal, out double j))
                    {
                        numbers[i] = j;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Forkert input");
                        continue;
                    }
                 
                }
            }
            return numbers;
        } //metode for at indlæse bruger input til et array

        private double CheckInput()
        {
            double output = 0;
            bool end = false;
            while (!end)
            {
                string tal = Console.ReadLine();
                if (Double.TryParse(tal, out double j))
                {
                    output = j;
                    end = true;
                }
                else
                {
                    Console.WriteLine("Forkert input");
                }

            }
            return output;
            
        }
        public void Call(string menuID)
        {
            switch (menuID)
            {
                case "add":
                    Console.WriteLine("Skriv det første tal: ");
                    double add1 = CheckInput();
                    Console.WriteLine("Skriv det andet tal: ");
                    double add2 = CheckInput();
                    Console.WriteLine(add1 + "+" + add2 + "=" + Calculator.Add(add1, add2)); //Prints the result in a pretty format
                    break;

                case "subtract":
                    Console.WriteLine("Skriv det første tal: ");
                    double subtract1 = CheckInput();
                    Console.WriteLine("Skriv det andet tal: ");
                    double subtract2 = CheckInput();
                    Console.WriteLine(subtract1 + "-" + subtract2 + "=" + Calculator.Subtract(subtract1, subtract2));
                    break;

                case "multiply":
                    Console.WriteLine("Skriv det første tal: ");
                    double multiply1 = CheckInput();
                    Console.WriteLine("Skriv det andet tal: ");
                    double multiply2 = CheckInput();
                    Console.WriteLine(multiply1 + "*" + multiply2 + "=" + Calculator.Multiply(multiply1, multiply2));
                    break;

                case "divide":
                    Console.WriteLine("Skriv det tal du vil dividere: ");
                    double divide1 = CheckInput();
                    Console.WriteLine("Skriv det tal du vil dividere med: ");
                    double divide2 = CheckInput();
                    Console.WriteLine(divide1 + "/" + divide2 + "=" + Calculator.Divide(divide1, divide2));
                    break;

                case "sum":
                     Console.WriteLine("Indtast tal for at få sum, afslut med 'ENTER':");
                     Console.WriteLine(("Sum af tal: ") + Calculator.Sum(ArrayInput())); //Sender et array fra ArrayInput videre til vores 'Sum' metode og printer resultatet.
                     break;

                case "minimum":
                    Console.WriteLine("Indtast tal for at finde minimum, afslut med 'ENTER':");
                    Console.WriteLine(("Minimum af indtastede tal: ") + Calculator.Minimum(ArrayInput())); //Sender et array fra ArrayInput videre til vores 'Minimum' metode og printer resultatet.
                    break;

                case "maximum":
                    Console.WriteLine("Indtast tal for at finde maximum, afslut med 'ENTER':");
                    Console.WriteLine(("Maximum af indtastede tal: ") + Calculator.Maximum(ArrayInput())); //Sender et array fra ArrayInput videre til vores 'Maximum' metode og printer resultatet.
                    break;

                case "average":
                    Console.WriteLine("Indtast tal for at finde gennemsnit, afslut med 'ENTER':");
                    Console.WriteLine(("Gennemsnit af indtastede tal: ") + Calculator.Average(ArrayInput())); //Sender et array fra ArrayInput videre til vores 'Average' metode og printer resultatet.
                    break;
                case "expression":
                    Console.WriteLine("Indtast en expression som kan indeholde + og -");
                    string input = Console.ReadLine();
                    Console.WriteLine("Expression giver: {0}", Calculator.Expression(input));
                    break;




                default:
                    Console.WriteLine("Menuen eksisterer ikke...");
                    break;
            }
        }
    }
}

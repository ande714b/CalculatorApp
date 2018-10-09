using System;
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

        public double[] ArrayInput()
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
                    numbers[i] = Convert.ToDouble(tal);
                    i++;
                }
            }
            return numbers;
        }

        public void Call(string menuID)
        {
            switch (menuID)
            {
                case "add":
                    Console.WriteLine("Skriv det første tal: ");
                    double add1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv det andet tal: ");
                    double add2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(add1 + "+" + add2 + "=" + Calculator.Add(add1, add2)); //Prints the result in a pretty format
                    break;

                case "subtract":
                    Console.WriteLine("Skriv det første tal: ");
                    double subtract1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv det andet tal: ");
                    double subtract2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(subtract1 + "-" + subtract2 + "=" + Calculator.Add(subtract1, subtract2));
                    break;

                case "multiply":
                    Console.WriteLine("Skriv det første tal: ");
                    double multiply1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv det andet tal: ");
                    double multiply2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(multiply1 + "*" + multiply2 + "=" + Calculator.Multiply(multiply1, multiply2));
                    break;

                case "divide":
                    Console.WriteLine("Skriv det tal du vil dividere: ");
                    double divide1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv det tal du vil dividere med: ");
                    double divide2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(divide1 + "/" + divide2 + "=" + Calculator.Divide(divide1, divide2));
                    break;

                case "sum":
                        Console.WriteLine("Indtast tal for at få sum, afslut med 'ENTER':");
                        Console.WriteLine(("Sum af tal: ") + Calculator.Sum(ArrayInput()));
                        break;

                case "minimum":
                        Console.WriteLine("Indtast tal for at finde minimum, afslut med 'ENTER':");
                        Console.WriteLine(("Minimum af indtastede tal: ") + Calculator.Minimum(ArrayInput()));
                        break;

                case "maximum":
                    Console.WriteLine("Indtast tal for at finde maximum, afslut med 'ENTER':");
                    Console.WriteLine(("Maximum af indtastede tal: ") + Calculator.Maximum(ArrayInput()));
                    break;

                case "average":
                    Console.WriteLine("Indtast tal for at finde gennemsnit, afslut med 'ENTER':"); //Hed det gennemsnit?
                    Console.WriteLine(("Gennemsnit af indtastede tal: ") + Calculator.Average(ArrayInput()));
                    break;

                default:
                    Console.WriteLine("Menuen eksisterer ikke...");
                    break;
            }
        }
    }
}

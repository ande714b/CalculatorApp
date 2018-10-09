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
                    bool end = false;
                    double[] sumarray = new double[10];
                    int i = 0;
                    Console.WriteLine("Indtast tal og få sum, afslut med 'ENTER' :");
                    while (!end)
                    {
                        string tal = Console.ReadLine();

                        if (tal == "")
                        {
                            Array.Resize(ref sumarray, i);
                            end = true;
                        }

                        else if (i > 9)
                        {

                            end = true;
                        }

                        else
                        {
                            sumarray[i] = Convert.ToDouble(tal);
                            i++;
                        }
                       
                    }
                    Console.Write("Sum af indtastede tal: ");
                    Console.WriteLine(Calculator.Sum(sumarray));
                    break;

                default:
                    Console.WriteLine("Menuen eksisterer ikke...");
                    break;
            }
        }
    }
}

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
                    Console.WriteLine("Skriv de to tal som du ville lægge sammen: ");
                    double add1 = double.Parse(Console.ReadLine());
                    double add2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Calculator.Add(add1, add2));
                    break;

                case "subtract":
                    Console.WriteLine("Skriv de to tal som du ville lægge sammen: ");
                    double subtract1 = double.Parse(Console.ReadLine());
                    double subtract2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Calculator.Add(subtract1, subtract2));
                    break;

                case "sum":
                    bool end = false;
                    double[] numbers = new double[10];
                    int i = 0;
                    Console.WriteLine("Indtast tal og få sum, afslut med 'ENTER' :");
                    while (!end)
                    {
                        string tal = Console.ReadLine();

                        if (tal == "/n")
                        {
                            Array.Resize(ref numbers, i);
                            break;
                        }
                        numbers[i] = double.Parse(tal);
                        i++;
                    }

                    break;

                default:
                    Console.WriteLine("Menuen eksisterer ikke...");
                    break;
            }
        }
    }
}

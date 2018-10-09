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
                    double[] sumarray = new double[20];
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

                        else if (i > 19)
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

                case "minimum":
                    {
                        bool end1 = false;  // fjollet måde at skrive end på, kan man bruge den tidligere bool somehow?
                        double[] minarray = new double[20];
                        int o = 0; // samme her som for bool, det fjollet
                        Console.WriteLine("Indtast tal for at finde minimum, afslut med 'ENTER' :");
                        while (!end1)
                        {
                            string tal1 = Console.ReadLine();

                            if (tal1 == "")
                            {
                                Array.Resize(ref minarray, o);
                                end1 = true;
                            }

                            else if (o > 19)
                            {

                                end1 = true;
                            }

                            else
                            {
                                minarray[o] = Convert.ToDouble(tal1);
                                o++;
                            }

                        }
                        Console.Write("Minimum af talrækken: ");
                        Console.WriteLine(Calculator.Minimum(minarray));
                        break;
                    }

                case "maximum":
                    bool end2 = false;  // fjollet måde at skrive end på, kan man bruge den tidligere bool somehow?
                    double[] maxarray = new double[20];
                    int p = 0; // samme her som for bool, det fjollet
                    Console.WriteLine("Indtast tal for at finde maximum, afslut med 'ENTER' :");
                    while (!end2)
                    {
                        string tal2 = Console.ReadLine(); // Kan man lave metode for disse linjer ? 
                                                          // Så de ikke behøver at stå 3 gange
                        if (tal2 == "")
                        {
                            Array.Resize(ref maxarray, p);
                            end2 = true;
                        }

                        else if (p > 19)
                        {

                            end2 = true;
                        }

                        else
                        {
                            maxarray[p] = Convert.ToDouble(tal2);
                            p++;
                        }

                    }
                    Console.Write("Maximum af talrækken: ");
                    Console.WriteLine(Calculator.Maximum(maxarray));
                    break;



                default:
                    Console.WriteLine("Menuen eksisterer ikke...");
                    break;
            }
        }
    }
}

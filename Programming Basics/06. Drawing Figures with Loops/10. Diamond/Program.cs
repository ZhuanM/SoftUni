using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenGorna4astDashesA = n / 2 - 2;
            int evenGorna4astDashesB = 2;
            int oddGorna4astDashesA = n / 2 - 1;
            int oddGorna4astDashesB = 1;

            int Dolna4astDashesB = n - 4;

            if (n == 1)
            {
                Console.WriteLine('*');
            }

            else if (n == 2)
            {
                Console.WriteLine("**");
            }

            else
            {
                //purvi red
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', n / 2 - 1));
                    Console.Write("**");
                    Console.WriteLine(new string('-', n / 2 - 1));
                }
                else
                {
                    Console.Write(new string('-', n / 2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', n / 2));
                }

                //gorna 4ast
                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n / 2 - 2; i++)
                    {
                        Console.Write(new string('-', evenGorna4astDashesA));
                        Console.Write('*');
                        Console.Write(new string('-', evenGorna4astDashesB));
                        Console.Write('*');
                        Console.WriteLine(new string('-', evenGorna4astDashesA));
                        evenGorna4astDashesA--;
                        evenGorna4astDashesB += 2;
                    }
                }
                else
                {
                    for (int i = 1; i <= n / 2 - 1; i++)
                    {
                        Console.Write(new string('-', oddGorna4astDashesA));
                        Console.Write('*');
                        Console.Write(new string('-', oddGorna4astDashesB));
                        Console.Write('*');
                        Console.WriteLine(new string('-', oddGorna4astDashesA));
                        oddGorna4astDashesA--;
                        oddGorna4astDashesB += 2;
                    }
                }

                //sreda
                Console.Write('*');
                Console.Write(new string('-', n - 2));
                Console.WriteLine('*');

                //dolna 4ast
                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n / 2 - 2; i++)
                    {
                        Console.Write(new string('-', i));
                        Console.Write('*');
                        Console.Write(new string('-', Dolna4astDashesB));
                        Console.Write('*');
                        Console.WriteLine(new string('-', i));
                        Dolna4astDashesB -= 2;
                    }
                }
                else
                {
                    for (int i = 1; i <= n / 2 - 1; i++)
                    {
                        Console.Write(new string('-', i));
                        Console.Write('*');
                        Console.Write(new string('-', Dolna4astDashesB));
                        Console.Write('*');
                        Console.WriteLine(new string('-', i));
                        Dolna4astDashesB -= 2;
                    }
                }
                //posleden red
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', n / 2 - 1));
                    Console.Write("**");
                    Console.WriteLine(new string('-', n / 2 - 1));
                }
                else
                {
                    Console.Write(new string('-', n / 2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', n / 2));
                }
            }
        }
    }
}
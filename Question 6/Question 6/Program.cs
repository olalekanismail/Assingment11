using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculate the area of a triangle by given:");
                Console.WriteLine("1.Three side lengths.");
                Console.WriteLine("2.Length of one side and it's altitude.");
                Console.WriteLine("3.Length of two sides and the angle between them.");
                Console.WriteLine("4.Exit.");
                Console.Write("Enter choice from 1 to 4: ");
                choice = System.Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ThreeSides(); 
                        break;
                    case 2:
                        SideAltitude(); 
                        break;
                    case 3: 
                        TwoSidesAngle(); 
                        break;
                }

            } while (choice != 4);
        }
            public static void ThreeSides()
            {
                Console.Write("Enter a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                float c = float.Parse(Console.ReadLine());
                float p = (a + b + c) / 2;
                Console.WriteLine("S is: {0}", (float)(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
                Console.ReadLine();
            }

            public static void SideAltitude()
            {
                Console.Write("Enter a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter h(a): ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("S is: {0}", (a * b) / 2);
                Console.ReadLine();
            }

            public static void TwoSidesAngle()
            {
                Console.Write("Enter a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Enter sine: ");
                float c = float.Parse(Console.ReadLine());
                Console.WriteLine("S is: {0}", (a * b * Math.Sin(c)) / 2);
                Console.ReadLine();
            }
        }
    }


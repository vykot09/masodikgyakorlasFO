using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} és {magassag}");

            int x = szelesseg / 2;
            int y = magassag / 2;

            int[] xKoord = new int[5];
            int[] yKoord = new int[5];

            for (int i = 0; i < 5; i++)
            {
                xKoord[i] = x + i;
                yKoord[i] = y;
            }

            Megrajzol(xKoord, yKoord);

            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (cki.Key != ConsoleKey.Escape)
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Balfele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Felfele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Jobbfele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Lefele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        break;
                }
            }

            Console.ReadKey(true);
        }

        static void Megrajzol(int[] x, int[] y)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x[i], y[i]);
                Console.Write('*');
            }
        }

        static void Felfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4];
            y[4] = atmenetY[4] - 1;
        }

        static void Lefele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4];
            y[4] = atmenetY[4] + 1;
        }

        static void Jobbfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4] + 1;
            y[4] = atmenetY[4];
        }

        static void Balfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 4; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[4] = atmenetX[4] - 1;
            y[4] = atmenetY[4];
        }
    }
}
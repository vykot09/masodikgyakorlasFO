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

            Random rnd = new Random();

            int x = szelesseg / 2;
            int y = magassag / 2;

            int[] pontokX = new int[10];
            int[] pontokY = new int[10];

           
            int[] xKoord = new int[5];
            int[] yKoord = new int[5];

            for (int i = 0; i < 5; i++)
            {
                xKoord[i] = x + i;
                yKoord[i] = y;
            }

            for (int i = 0; i < 10; i++)
            {
                pontokX[i] = rnd.Next(0, szelesseg);
                pontokY[i] = rnd.Next(0, magassag);
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
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xKoord[xKoord.Length - 1] && pontokY[i] == yKoord[yKoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Felfele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xKoord[xKoord.Length - 1] && pontokY[i] == yKoord[yKoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Jobbfele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xKoord[xKoord.Length - 1] && pontokY[i] == yKoord[yKoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Lefele(ref xKoord, ref yKoord);
                        Megrajzol(xKoord, yKoord);
                        for (int i = 0; i < pontokX.Length; i++)
                        {
                            if (pontokX[i] == xKoord[xKoord.Length - 1] && pontokY[i] == yKoord[yKoord.Length - 1])
                            {
                                pontokX = EggyelCsokkent(pontokX[i], pontokX);
                                pontokY = EggyelCsokkent(pontokY[i], pontokY);
                            }
                        }
                        break;
                }
            }

            Console.ReadKey(true);
        }

        static void Megrajzol(int[] x, int[] y)
        {
            for (int i = 0; i < x.Length; i++)
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
        static int[] EggyelCsokkent(int szam, int[] a)
        {
            int[] b = new int[a.Length - 1];

            for (int i = 0; i < a.Length; i++)
            {
                if (szam != a[i])
                {
                     b[i] = a[i];
                }
                else if(szam == a[i] && i != a.Length -1)
                {
                    b[i++] = a[i + 1];
                }
            }

            return b;
        }
    }
}
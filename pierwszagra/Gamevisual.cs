using System;
using System.Threading;

namespace pierwszagra
{
    internal class Gamevisual
    {
        string[] kord = new string[10];
        int wyborstrony;
        string wybrano;
        string kordynaty;
        string actualruch;
        int x;
        int y;
        bool wygrana = false;

        public Gamevisual()
        {
            for (int i = 1; i < 10; i++)
            {
                kord[i] = "-";
            }

            Console.Clear();
            Console.WriteLine($"  1 2 3");
            Console.WriteLine($"1 {kord[1]} {kord[2]} {kord[3]}");
            Console.WriteLine($"2 {kord[4]} {kord[5]} {kord[6]}"); // zmiana z 0 na 10 i z 10 na 11 test
            Console.WriteLine($"3 {kord[7]} {kord[8]} {kord[9]}");

            do
            {
                Console.WriteLine("Wybierz kto zaczyna gre wpisując numer podany ponizej");
                Console.WriteLine("1.X");
                Console.WriteLine("2.O");
                wyborstrony = Console.Read();

                if (wyborstrony == 49)
                {
                    wybrano = "X";
                }
                else
                {
                    if (wyborstrony == 50)
                    {
                        wybrano = "O";
                    }
                    else
                    {
                        Console.WriteLine("Nie ma takiej opcji");
                    }
                }
            }
            while (wyborstrony == 49 || wyborstrony == 50);
            Console.Clear();

            while (wygrana == false)
            {
                Console.WriteLine($"wpisz kordynaty od 1 do 3 zaczynając od gornych opdzielajac spacją dla {wybrano}");
                Thread.Sleep(300);
                kordynaty = Console.ReadLine();

                if (kordynaty[1] == '1' || kordynaty[1] == '2' || kordynaty[1] == '3' && kordynaty[2] == ' ' && kordynaty[3] == 1 || kordynaty[3] == '2' || kordynaty[3] == '3')
                {
                    int pierwszy_raz = 1;
                    pierwszy_raz += 1;
                    x = kordynaty[0];
                    y = kordynaty[2];

                    if (pierwszy_raz == 1)
                    {
                        actualruch = wybrano;
                    }
                    else
                    {
                        if (actualruch == "X")
                        {
                            actualruch = "O";
                        }
                        else
                        {
                            actualruch = "X";
                        }
                    }

                    kord[x + y - 1] = actualruch;

                    Console.Clear();
                    Console.WriteLine($"  1 2 3");
                    Console.WriteLine($"1 {kord[1]} {kord[2]} {kord[3]}");
                    Console.WriteLine($"2 {kord[4]} {kord[5]} {kord[6]}");
                    Console.WriteLine($"3 {kord[7]} {kord[8]} {kord[9]}");

                    if (kord[1] == "X" && kord[2] == "X" && kord[3] == "X" || kord[1] == "O" && kord[2] == "O" && kord[3] == "O" ||
                        kord[4] == "X" && kord[5] == "X" && kord[6] == "X" || kord[4] == "O" && kord[5] == "O" && kord[6] == "O" ||
                        kord[7] == "X" && kord[8] == "X" && kord[9] == "X" || kord[7] == "O" && kord[8] == "O" && kord[9] == "O" ||

                        kord[1] == "X" && kord[4] == "X" && kord[7] == "X" || kord[1] == "O" && kord[4] == "O" && kord[7] == "O" ||
                        kord[8] == "X" && kord[5] == "X" && kord[2] == "X" || kord[8] == "O" && kord[5] == "O" && kord[2] == "O" ||
                        kord[9] == "X" && kord[6] == "X" && kord[3] == "X" || kord[9] == "O" && kord[6] == "O" && kord[3] == "O" ||

                        kord[7] == "X" && kord[5] == "X" && kord[3] == "X" || kord[7] == "O" && kord[5] == "O" && kord[3] == "O" ||
                        kord[9] == "X" && kord[5] == "X" && kord[1] == "X" || kord[9] == "O" && kord[5] == "O" && kord[1] == "O")
                    {
                        wygrana = true;
                        Console.WriteLine($"Brawo! Wygrał łeś");

                    }

                }

                

            }
        }

    }
}
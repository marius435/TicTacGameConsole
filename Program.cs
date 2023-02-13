using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGameConsole
{
    internal class Program
    {
        static int player = 1;
        static string[,] campuri =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };
        static string[] simbol = { "X", "O" };

        static void Main(string[] args)
        {
            game();
        }

        static void game()
        {
            int input = 0;

            afisare();
            Console.Write("\nPlayer {0}  Introduceti numarul campului: ", player);

            do
            { 
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    valoareIntrodusa(input,ref player);
                }
                catch
                {
                    Console.Clear();
                    afisare();
                    Console.WriteLine("Va rog introduceti o valoare valida!");
                    Console.Write("\nPlayer {0}  Introduceti numarul campului: ", player);
                }

                Console.Clear();
                afisare();
                Console.Write("\nPlayer {0}  Introduceti numarul campului: ", player);
                verificareCastigator();

            } while (true);
        }

        static void afisare()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", campuri[0, 0], campuri[0, 1], campuri[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", campuri[1, 0], campuri[1, 1], campuri[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", campuri[2, 0], campuri[2, 1], campuri[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        static void verificareCastigator()
        {
            // verificare pe verticala si orizontala
            for (int i = 0; i < 3; i++)
            {
                if (campuri[0, i] == campuri[1, i] && campuri[1, i] == campuri[2, i])
                {
                    if (campuri[0, i] == "X")
                    {
                        Console.Clear();
                        afisare();
                        Console.WriteLine("Player 1 a castigat!");
                        initializare();
                        Console.Read();
                    }
                    else
                    {
                        Console.Clear();
                        afisare();
                        Console.WriteLine("Player 2 a castigat!");
                        initializare();
                        Console.Read();
                    }
                }
                if (campuri[i, 0] == campuri[i, 1] && campuri[i, 1] == campuri[i, 2])
                {
                    if (campuri[i, 0] == "X")
                    {
                        Console.Clear();
                        afisare();
                        Console.WriteLine("Player 1 a castigat!");
                        initializare();
                        Console.Read();
                    }
                    else
                    {
                        Console.Clear();
                        afisare();
                        Console.WriteLine("Player 2 a castigat!");
                        initializare();
                        Console.Read();
                    }
                }
            }

            // verificare pe diagonala
            if (campuri[0, 0] == campuri[1, 1] && campuri[1, 1] == campuri[2, 2])
            {
                if (campuri[0, 0] == "X")
                {
                    Console.Clear();
                    afisare();
                    Console.WriteLine("Player 1 a castigat!");
                    initializare();
                    Console.Read();
                }
                else
                {
                    Console.Clear();
                    afisare();
                    Console.WriteLine("Player 2 a castigat!");
                    initializare();
                    Console.Read();
                }
            }
            if (campuri[0, 2] == campuri[1, 1] && campuri[1, 1] == campuri[2, 0])
            {
                if (campuri[2, 0] == "X")
                {
                    Console.Clear();
                    afisare();
                    Console.WriteLine("Player 1 a castigat!");
                    initializare();
                    Console.Read();
                }
                else
                {
                    Console.Clear();
                    afisare();
                    Console.WriteLine("Player 2 a castigat!");
                    initializare();
                    Console.Read();
                }
            }

            // verificare daca mai sunt campuri goale
            bool draw = true;
            for (int i = 0; i < 3 && draw == true; i++)
            {
                for (int j = 0; j < 3 && draw == true; j++)
                {
                    if (campuri[i, j] != "X" && campuri[i, j] != "O")
                        draw = false;
                }
            }
            if (draw == true)
            {
                Console.Clear();
                afisare();
                Console.WriteLine("Egalitate!");
                initializare();
                Console.Read();
            }
        }

        static void initializare()
        {
            int nr = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    campuri[i, j] = nr.ToString();
                    nr++;
                }
            }
            player = 1;
        }

        static void valoareIntrodusa(int input, ref int player)
        {
            switch(input)
            {
                case 1:
                    if (campuri[0, 0] == "1")
                    {
                        campuri[0, 0] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 2:
                    if (campuri[0, 1] == "2")
                    {
                        campuri[0, 1] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 3:
                    if (campuri[0, 2] == "3")
                    {
                        campuri[0, 2] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 4:
                    if (campuri[1, 0] == "4")
                    {
                        campuri[1, 0] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 5:
                    if (campuri[1, 1] == "5")
                    {
                        campuri[1, 1] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 6:
                    if (campuri[1, 2] == "6")
                    {
                        campuri[1, 2] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 7:
                    if (campuri[2, 0] == "7")
                    {
                        campuri[2, 0] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 8:
                    if (campuri[2, 1] == "8")
                    {
                        campuri[2, 1] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                case 9:
                    if (campuri[2, 2] == "9")
                    {
                        campuri[2, 2] = simbol[player - 1];
                        if (player == 1) player = 2;
                        else player = 1;
                    }
                    break;
                default:
                    afisare();
                    Console.WriteLine("Camp ocupat!");
                    Console.Write("\nPlayer {0}: ", player);
                    break;
            }
        }
    }
}

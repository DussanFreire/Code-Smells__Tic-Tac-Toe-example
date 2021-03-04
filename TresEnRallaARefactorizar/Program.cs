using System;

namespace TresEnRallaARefactorizar
{
    class Program
    {
        static void Main(string[] args)
        {
            int ketchup;
            do
            {
                string[,] t = new string[3, 3] { { "_", "_", "_" }, { "_", "_", "_" }, { "_", "_", "_" } };
                Console.WriteLine("************MENU*************");
                Console.WriteLine("1. Juego Nuevo");
                Console.WriteLine("0. Salir");
                bool winner =true;
                ketchup = int.Parse(Console.ReadLine());
                if (ketchup == 1) {
                    int t1 = 1;
                    do
                    {
                        if ((t[0, 0] == "*" && t[0, 1] == "*" && t[0, 2] == "*") ||
                            (t[1, 0] == "*" && t[1, 1] == "*" && t[1, 2] == "*") ||
                            (t[2, 0] == "*" && t[2, 1] == "*" && t[2, 2] == "*") ||
                            (t[0, 0] == "*" && t[1, 0] == "*" && t[2, 0] == "*") ||
                            (t[0, 1] == "*" && t[1, 1] == "*" && t[2, 1] == "*") ||
                            (t[0, 2] == "*" && t[1, 2] == "*" && t[2, 2] == "*") ||
                            (t[0, 0] == "*" && t[1, 1] == "*" && t[2, 2] == "*") ||
                            (t[0, 2] == "*" && t[1, 1] == "*" && t[2, 0] == "*")
                            )
                        {
                            Console.WriteLine("Gano el jugador 2");
                            winner = false;
                            break;
                        }
                        if ((t[0, 0] == "x" && t[0, 1] == "x" && t[0, 2] == "x") ||
                            (t[1, 0] == "x" && t[1, 1] == "x" && t[1, 2] == "x") ||
                            (t[2, 0] == "x" && t[2, 1] == "x" && t[2, 2] == "x") ||
                            (t[0, 0] == "x" && t[1, 0] == "x" && t[2, 0] == "x") ||
                            (t[0, 1] == "x" && t[1, 1] == "x" && t[2, 1] == "x") ||
                            (t[0, 2] == "x" && t[1, 2] == "x" && t[2, 2] == "x") ||
                            (t[0, 0] == "x" && t[1, 1] == "x" && t[2, 2] == "x") ||
                            (t[0, 2] == "x" && t[1, 1] == "x" && t[2, 0] == "x")
                            )
                        {
                            Console.WriteLine("Gano el jugador 1");
                            winner = false;
                            break;
                        }
                        Console.WriteLine("Tablero:");
                        for (int haha=0; haha < 3; haha++) {
                            for (int hehe = 0; hehe < 3; hehe++)
                            {
                                Console.Write($"{t[haha, hehe]} {((hehe < 2) ? "\t" : "\n")}");
                            }
                        }
                        if(t1%2==0)
                            Console.WriteLine("Jugador 2:");
                        else
                            Console.WriteLine("Jugador 1:");

                        Console.WriteLine("Ingrese la cordenada en x (Coordenadas validad: 1, 2, 3):");
                        int cx = int.Parse(Console.ReadLine())-1;
                        Console.WriteLine("Ingrese la cordenada en y (Coordenadas validad: 1, 2, 3):");
                        int cy = int.Parse(Console.ReadLine()) - 1;
                        if (t[cx, cy] != "_")
                        {
                            Console.WriteLine("Posicion invalida.");
                        }
                        else {
                            t[cx, cy] = ((t1 % 2 != 0) ? "x" : "*");
                            t1++;
                        }

                    } while (winner);
                }
                Console.WriteLine("Tablero:");
                for (int haha = 0; haha < 3; haha++)
                {
                    for (int hehe = 0; hehe < 3; hehe++)
                    {
                        Console.Write($"{t[haha, hehe]} {((hehe < 2) ? "\t" : "\n")}");
                    }
                }
            } while (ketchup != 0);
            Console.WriteLine("_");
        }
    }
}

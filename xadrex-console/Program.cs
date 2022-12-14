using System;
using xadrex_console.tabuleiro;

namespace xadrex_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine("Posição: " + P);
            */

            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}

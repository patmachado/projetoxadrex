using System;
using xadrex_console.tabuleiro;
using xadrex;

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
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}

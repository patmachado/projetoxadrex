using System;
using System.Collections.Generic;
using System.Text;
using xadrex;
using xadrex_console.tabuleiro;
using xadrex_console.xadrex;

namespace xadrex_console
{
    class Tela
    {

        public static void imprimirPartida(PartidaXadrex partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);

            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando Jogada: " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("!!! Xeque !!!");
            }
        }

        public static void imprimirPecasCapturadas(PartidaXadrex partida)
        {
            Console.WriteLine("Peças Capturadas: ");
            Console.Write("Brancas ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();

            Console.Write("Pretas ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor= aux;
            Console.WriteLine() ;
        }
        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[ ");
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write(" ]");

        }

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                        ImprimirPeca(tab.peca(i, j));                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = Console.ForegroundColor;


            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

        public static PosicaoXadrex LerPosicaoXadrex()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrex(coluna, linha);
        }
    }
}
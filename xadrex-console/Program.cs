using System;
using xadrex_console.tabuleiro;
using xadrex;
using xadrex_console.xadrex;

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
            try
            {
                /*
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                Tela.imprimirTabuleiro(tab);
                
                PosicaoXadrex pos = new PosicaoXadrex('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
                */

                PartidaXadrex partida = new PartidaXadrex();

                while (!partida.encerrada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrex().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();


                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrex().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                Tela.imprimirTabuleiro(partida.tab);



            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);

            }

            Console.ReadLine();

        }
    }
}

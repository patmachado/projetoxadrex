using System;
using System.Collections.Generic;
using System.Text;
using xadrex_console.tabuleiro;

namespace xadrex
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;

        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca)
            {
                pos.definirValores(posicao.linha - 1, posicao.coluna);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.definirValores(posicao.linha - 2, posicao.coluna);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                
                pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                
                pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

            }
            else
            {
                pos.definirValores(posicao.linha + 1, posicao.coluna);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.definirValores(posicao.linha + 2, posicao.coluna);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

                pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }

            }
         
            return mat;

        }

    }
}

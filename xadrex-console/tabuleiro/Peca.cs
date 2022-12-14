using System;
using System.Collections.Generic;
using System.Text;

namespace xadrex_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdmoves { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdmoves = 0;
        }
        public void AddQtdMovimentos()
        {
            qtdmoves++;
        }

        public abstract bool[,] movimentosPossiveis();

    }
}

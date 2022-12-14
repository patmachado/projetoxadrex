using System;
using System.Collections.Generic;
using System.Text;
using xadrex_console.tabuleiro;
using xadrex_console.xadrex;

namespace xadrex
{
    class PartidaXadrex
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool encerrada { get; private set; }

        public PartidaXadrex()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            encerrada = false;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.AddQtdMovimentos();
            Peca pecaAtiva = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('c', 1).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('c', 2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('d', 2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('e', 2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('e', 1).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrex('d', 1).toPosicao());

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 8).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('d', 7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('e', 7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('e', 8).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrex('d', 8).toPosicao());

        }
    }
}

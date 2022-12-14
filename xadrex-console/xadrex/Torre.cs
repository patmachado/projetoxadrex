using System;
using System.Collections.Generic;
using System.Text;
using xadrex_console.tabuleiro;

namespace xadrex
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}

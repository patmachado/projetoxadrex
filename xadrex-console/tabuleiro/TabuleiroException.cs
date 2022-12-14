using System;
using System.Collections.Generic;
using System.Text;

namespace xadrex_console.tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) { 
        }
    }
}

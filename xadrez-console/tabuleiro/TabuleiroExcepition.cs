using System;

namespace xadrez_console.tabuleiro
{
    internal class TabuleiroExcepition : Exception
    {
        public TabuleiroExcepition(string msg) : base(msg)
        {
        }
    }
}

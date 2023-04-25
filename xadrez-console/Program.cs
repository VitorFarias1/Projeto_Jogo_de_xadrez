using System;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(0, 2));

                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(1, 5));

                Tela.impriimirTabuleiro(tab);
            }
            catch (TabuleiroExcepition e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
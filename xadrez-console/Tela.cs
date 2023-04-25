using System;
using tabuleiro;
namespace xadrez_console
{
    internal class Tela
    {
        public static void impriimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i , j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.peca(i , j));
                        Console.Write(" ");
                    }                    
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");
        }

        public static void ImprimirPeca (Peca peca)
        {
            if (peca.cor == Cor.Branco)
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
        }
    }
}

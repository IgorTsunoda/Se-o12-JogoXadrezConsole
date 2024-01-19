using tabuleiro;

namespace Xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                for(int j = 0; i <tab.Colunas; j++)
                {
                    Console.WriteLine(tab.peca(i, j) + " ");
                    if (tab.peca(i,j) == null)
                    {
                        Console.WriteLine("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

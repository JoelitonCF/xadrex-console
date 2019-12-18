using System;
using tabuleiro;
using xadres;

namespace xadrex_console
{
    class Program
    {   
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 2));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 0));

            Tela.imprimirTabuleiro(tab);
        }
    }
}

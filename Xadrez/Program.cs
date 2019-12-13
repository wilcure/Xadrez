using System;
using Xadrez.tabuleiro;
using Xadrez.Jogo;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PartidadeXadrez partida = new PartidadeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);

                }
                


            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

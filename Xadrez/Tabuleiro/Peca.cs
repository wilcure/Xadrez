using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            QtdMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQntMovimento()
        {
            QtdMovimentos++;
        }
    }
}

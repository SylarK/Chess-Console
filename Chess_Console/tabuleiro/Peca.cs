using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; } // uma peça possui uma posição
        public Cor cor { get; protected set; } // uma peça possui uma cor
        public int qteMovimentos { get; protected set; } //controlar a quantidade de movimentos (ex. Peão)
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }

    }
}

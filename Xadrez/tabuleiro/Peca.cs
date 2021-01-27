using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.tabuleiro {
    class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimento { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro) {
            Posicao = null ;
            Cor = cor;
            Tabuleiro = tabuleiro;
            this.QuantidadeMovimento = 0;
        }
    }
}

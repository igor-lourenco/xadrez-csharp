using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class PosicaoXadrez {

        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        //Converte a posicao do xadrez para uma posicao interna da matriz
        public Posicao toPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }


        public override string ToString() {
            return "" + Coluna + Linha;
        }
    }
}

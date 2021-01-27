using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.tabuleiro {
    abstract class Peca {

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

        public void IncrementarQuantidadeMovimentos() {
            QuantidadeMovimento++;
        }

        public void DecrementarQuantidadeMovimentos() {
            QuantidadeMovimento--;
        }

        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tabuleiro.Linhas; i++) {
                for(int j = 0; j < Tabuleiro.Colunas; j++) {
                    if (mat[i, j])
                        return true;
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos) {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}

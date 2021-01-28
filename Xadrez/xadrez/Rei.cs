using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class Rei :Peca {

        private PartidaXadrez Partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base (cor, tab) {
            Partida = partida;

        }

        private bool PodeMover(Posicao pos) {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao pos) {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QuantidadeMovimento == 0;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Direita
            pos.DefinirValores(Posicao.Linha , Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna );
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Esquerdo
            pos.DefinirValores(Posicao.Linha , Posicao.Coluna -1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //Noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna -1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;


            // #Jogada Especial roque

            if (QuantidadeMovimento == 0 && !Partida.Xeque) {

                //#Jogada especial roque pequeno
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posT1)) {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null)
                        mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                }

                //#Jogada especial roque grande
                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posT1)) {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null && Tabuleiro.peca(p3) == null)
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                }
            }

                return mat;
        }

        public override string ToString() {
            return "R ";
        }
    }
}

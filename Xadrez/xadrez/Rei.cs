﻿using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez.xadrez {
    class Rei :Peca {

        public Rei(Tabuleiro tab, Cor cor) : base (cor, tab) {

        }

        private bool PodeMover(Posicao pos) {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
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

            return mat;
        }

        public override string ToString() {
            return "R ";
        }
    }
}

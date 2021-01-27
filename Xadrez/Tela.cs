﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                    ImprimirPeca(tab.peca(i, j));

                Console.WriteLine();
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.Green;

            for (int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++) {
                    if (posicoesPossiveis[i, j])
                        Console.BackgroundColor = fundoAlterado;
                    else
                        Console.BackgroundColor = fundoOriginal;

                    ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }


                Console.WriteLine();
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez() {
            String s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca == null)
                Console.Write("-  ");
            else {
                if (peca.Cor == Cor.Branca)
                    Console.Write(peca);
                else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}

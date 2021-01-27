using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tab) {
            for(int i = 0; i < tab.Linhas; i++) {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++) {
                    if(tab.peca(i,j) == null)
                        Console.Write("-  ");
                    else {
                        ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H");
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branca)
                Console.Write(peca);
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }


        }
    }
}

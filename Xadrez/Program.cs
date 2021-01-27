﻿using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {


            try {

                PartidaXadrez partida = new PartidaXadrez();
                while (!partida.Terminada) {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
                

                
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }
    }
}

using System;
using Xadrez.tabuleiro;
using Xadrez.xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {


            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
        }
    }
}

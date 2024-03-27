using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);  

            while (campoMinado.JogoStatus == 0) {
                Console.WriteLine("");
                Console.WriteLine("=== DIGITE UMA POSIÇÃO ===");
                Console.WriteLine("");
                Console.WriteLine("Digite números de 1 a 9.");
                Console.WriteLine("");
                Console.WriteLine("Linha: ");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("");  

                campoMinado.Abrir(l, c);

                switch (campoMinado.JogoStatus) {
                    case 0:
                        jogoAberto();
                        break;
                    case 1:
                        vitoriaJogo();
                        break;
                    case 2:
                        gameOver();
                        break;
                }

                Console.WriteLine(campoMinado.Tabuleiro);
            }
        }

        static void jogoAberto()
        {
            Console.WriteLine("Jogo em aberto, continue procurando as casas que não possuem bombas!");  
        }

        static void gameOver()
        {
            Console.WriteLine("GameOver, você encontrou uma bomba!");
        }

        static void vitoriaJogo()
        {
            Console.WriteLine("Vitória, você encontrou todas as casas que não possui bomba!");   
        }
    }
}

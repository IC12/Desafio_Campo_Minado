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
            
            campoMinado.Abrir(l, c);

            if(l == 4 && c == 1)
            {
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine(campoMinado.JogoStatus);
                jogoAberto();
                Console.WriteLine("Linha: ");
                l = int.Parse(Console.ReadLine());
                Console.WriteLine("Coluna: ");
                c = int.Parse(Console.ReadLine());    
            } else if(l == 5 && c == 3)
                {
                    Console.WriteLine(campoMinado.Tabuleiro);
                    Console.WriteLine(campoMinado.JogoStatus);
                    jogoAberto();
                    Console.WriteLine("Linha: ");
                    l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coluna: ");
                    c = int.Parse(Console.ReadLine());  
                } else if(l == 5 && c == 2)
                    {
                        Console.WriteLine(campoMinado.Tabuleiro);
                        Console.WriteLine(campoMinado.JogoStatus);
                        jogoAberto();
                        Console.WriteLine("Linha: ");
                        l = int.Parse(Console.ReadLine());
                        Console.WriteLine("Coluna: ");
                        c = int.Parse(Console.ReadLine());    
                    } else if(l == 5 && c == 1)
                        {
                            Console.WriteLine(campoMinado.Tabuleiro);
                            Console.WriteLine(campoMinado.JogoStatus);
                            jogoAberto();
                            Console.WriteLine("Linha: ");
                            l = int.Parse(Console.ReadLine());
                            Console.WriteLine("Coluna: ");
                            c = int.Parse(Console.ReadLine());    
                        } else if(l == 5 && c == 6)
                            {
                                Console.WriteLine(campoMinado.Tabuleiro);
                                Console.WriteLine(campoMinado.JogoStatus);
                                jogoAberto();
                                Console.WriteLine("Linha: ");
                                l = int.Parse(Console.ReadLine());
                                Console.WriteLine("Coluna: ");
                                c = int.Parse(Console.ReadLine());    
                            } else if(l == 6 && c == 1)
                                {
                                    Console.WriteLine(campoMinado.Tabuleiro);
                                    Console.WriteLine(campoMinado.JogoStatus);
                                    jogoAberto();
                                    Console.WriteLine("Linha: ");
                                    l = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Coluna: ");
                                    c = int.Parse(Console.ReadLine());    
                                } else if(l == 6 && c == 2)
                                    {
                                        Console.WriteLine(campoMinado.Tabuleiro);
                                        Console.WriteLine(campoMinado.JogoStatus);
                                        jogoAberto();
                                        Console.WriteLine("Linha: ");
                                        l = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Coluna: ");
                                        c = int.Parse(Console.ReadLine());    
                                    } else if(l == 6 && c == 3)
                                        {
                                            Console.WriteLine(campoMinado.Tabuleiro);
                                            Console.WriteLine(campoMinado.JogoStatus);
                                            jogoAberto();
                                            Console.WriteLine("Linha: ");
                                            l = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Coluna: ");
                                            c = int.Parse(Console.ReadLine());    
                                        } else if(l == 6 && c == 4)
                                            {
                                                Console.WriteLine(campoMinado.Tabuleiro);
                                                Console.WriteLine(campoMinado.JogoStatus);
                                                jogoAberto();
                                                Console.WriteLine("Linha: ");
                                                l = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Coluna: ");
                                                c = int.Parse(Console.ReadLine());    
                                            } else if(l == 6 && c == 7)
                                                {
                                                    Console.WriteLine(campoMinado.Tabuleiro);
                                                    Console.WriteLine(campoMinado.JogoStatus);
                                                    jogoAberto();
                                                    Console.WriteLine("Linha: ");
                                                    l = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Coluna: ");
                                                    c = int.Parse(Console.ReadLine());    
                                                } else if(l == 6 && c == 9)
                                                    {
                                                        Console.WriteLine(campoMinado.Tabuleiro);
                                                        Console.WriteLine(campoMinado.JogoStatus);
                                                        jogoAberto();
                                                        Console.WriteLine("Linha: ");
                                                        l = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("Coluna: ");
                                                        c = int.Parse(Console.ReadLine());    
                                                    } else if(l == 7 && c <= 8)
                                                        {
                                                            Console.WriteLine(campoMinado.Tabuleiro);
                                                            Console.WriteLine(campoMinado.JogoStatus);
                                                            jogoAberto();
                                                            Console.WriteLine("Linha: ");
                                                            l = int.Parse(Console.ReadLine());
                                                            Console.WriteLine("Coluna: ");
                                                            c = int.Parse(Console.ReadLine());
                                                        } else if(l == 8 && c <= 9)
                                                            {
                                                                Console.WriteLine(campoMinado.Tabuleiro);
                                                                Console.WriteLine(campoMinado.JogoStatus);
                                                                jogoAberto();
                                                                Console.WriteLine("Linha: ");
                                                                l = int.Parse(Console.ReadLine());
                                                                Console.WriteLine("Coluna: ");
                                                                c = int.Parse(Console.ReadLine());
                                                            } else if(l == 9 && c <= 9)
                                                                {
                                                                    Console.WriteLine(campoMinado.Tabuleiro);
                                                                    Console.WriteLine(campoMinado.JogoStatus);
                                                                    jogoAberto();
                                                                    Console.WriteLine("Linha: ");
                                                                    l = int.Parse(Console.ReadLine());
                                                                    Console.WriteLine("Coluna: ");
                                                                    c = int.Parse(Console.ReadLine());
                                                                } else
                                                                    {
                                                                        Console.WriteLine(campoMinado.Tabuleiro);
                                                                        Console.WriteLine(campoMinado.JogoStatus);
                                                                        vitoriaJogo();
                                                                    } 

            campoMinado.Abrir(l, c);

            if(l == 1 && c == 9)
            {
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine(campoMinado.JogoStatus);
                gameOver();  
            } else if(l == 4 && c == 2)
                {
                    Console.WriteLine(campoMinado.Tabuleiro);
                    Console.WriteLine(campoMinado.JogoStatus);
                    gameOver(); 
                } else if(l == 4 && c == 3)
                    {
                        Console.WriteLine(campoMinado.Tabuleiro);
                        Console.WriteLine(campoMinado.JogoStatus);
                        gameOver();   
                    } else if(l == 5 && c == 4)
                        {
                            Console.WriteLine(campoMinado.Tabuleiro);
                            Console.WriteLine(campoMinado.JogoStatus);
                            gameOver();  
                        } else if(l == 5 && c == 5)
                            {
                                Console.WriteLine(campoMinado.Tabuleiro);
                                Console.WriteLine(campoMinado.JogoStatus);
                                gameOver();  
                            } else if(l == 5 && c == 7)
                                {
                                    Console.WriteLine(campoMinado.Tabuleiro);
                                    Console.WriteLine(campoMinado.JogoStatus);
                                    gameOver();   
                                } else if(l == 6 && c == 5)
                                    {
                                        Console.WriteLine(campoMinado.Tabuleiro);
                                        Console.WriteLine(campoMinado.JogoStatus);
                                        gameOver();   
                                    } else if(l == 6 && c == 6)
                                        {
                                            Console.WriteLine(campoMinado.Tabuleiro);
                                            Console.WriteLine(campoMinado.JogoStatus);
                                            gameOver();   
                                        } else if(l == 6 && c == 8)
                                            {
                                                Console.WriteLine(campoMinado.Tabuleiro);
                                                Console.WriteLine(campoMinado.JogoStatus);
                                                gameOver();

                                            } else if(l == 7 && c == 9)
                                                {
                                                    Console.WriteLine(campoMinado.Tabuleiro);
                                                    Console.WriteLine(campoMinado.JogoStatus);
                                                    gameOver();    
                                                }

        }
    }
}

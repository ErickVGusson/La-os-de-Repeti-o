using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laços_de_Repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menu;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1 - Contagem Crescente");
            Console.WriteLine("2 - Tabuada");
            Console.WriteLine("3 - Soma de números");
            Console.WriteLine("4 - Advinhe o número");
            Console.Write("\nSelecione a função desejada: ");
            Console.ForegroundColor = ConsoleColor.Red;
            menu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if ( menu == 1 ) 
            {

                Console.Clear();
                Console.WriteLine("1 - Contagem Crescente \n");

                int contador = 1;

                int escolha_usuario;

                Console.Write("Digite um número: ");
                Console.ForegroundColor= ConsoleColor.Red;
                escolha_usuario = int.Parse(Console.ReadLine());

                while ( contador <= escolha_usuario )
                {
                    
                    Console.WriteLine( contador );
                    contador++;
                
                }

            }

            if ( menu == 2 )
            {

                Console.Clear();
                Console.WriteLine("2 - Tabuada\n");

                int contador = 1;
                int escolha_usuario;

                Console.Write("Digite o número que deseja saber a tabuada: ");
                escolha_usuario= int.Parse(Console.ReadLine());

                while ( contador <= 10)
                {

                    int multiplicado = contador * escolha_usuario;

                    Console.WriteLine( escolha_usuario + " X " + contador + " = " + multiplicado );

                    contador++;

                }


            }

            if( menu == 3 )
            {

                Console.Clear();
                Console.WriteLine("3 - Soma dos números\n");

                int contador = 1;
                int escolha_usuario;
                int soma_total = 0;

                Console.Write("Escolha quantos números desejas somar: ");
                Console.ForegroundColor = ConsoleColor.Red;
                escolha_usuario = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                while (contador <= escolha_usuario)
                {

                    Console.Write("Digite o " + contador + "º número: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    soma_total += int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    contador++;

                }
                Console.Write("O valor total deu: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(soma_total);



            }

            if ( menu == 4 )
            {

                Console.Clear();
                Console.WriteLine("4 - Advinhe o número\n");

                Random numero = new Random();
                int valor = numero.Next(0, 101);
                int chute = 0;
                int tentativas = 0;
                //Console.WriteLine(valor);

                while ( chute != valor ) 
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Chute um número: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    chute = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    tentativas++;

                    if (chute < valor)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("O seu chute está abaixo!!");

                    }
                    else if (chute > valor)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("O seu chute está acima");

                    }
                    else 
                    {

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Parabens!!!! Você acertou!!!! Em apenas " + tentativas + " tentativas!!!!");
                            
                    }
                    
                }


            }




            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\nPressione qualquer tecla para encerrar o programa");
            Console.ReadKey();

        }
    }
}

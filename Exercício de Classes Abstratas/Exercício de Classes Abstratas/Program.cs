using System.Reflection;
using System;

namespace Exercício_de_Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SMARTPHONE\n");

            Console.WriteLine("Qual desses smartphones deseja?");
            Console.WriteLine("M - Motorola");
            Console.WriteLine("I - Iphone");

            Console.Write("\nDigite uma das opções acima: ");
            char smartphone;
            do
            {
                char.TryParse(Console.ReadLine().ToUpper(), out smartphone);

                if (smartphone != 'M' && smartphone != 'I')
                {
                    Console.WriteLine("Opção Invalida\n");
                    Console.Write("Digite M para MOTOROLA e I para IPHONE: ");
                }

            } while (smartphone != 'M' && smartphone != 'I');

            Console.Clear();

            string numero, modelo, iMEI, nome;
            int memoria;
            char opcaoUsuario;

            switch (smartphone)
            {
                case 'M':
                    numero = "(11) 12345-6789";
                    modelo = "motorola edge 30 ultra 5G";
                    iMEI = "111111-11-111111-1";
                    memoria = 256;
                    Motorola motorola = new Motorola(numero, modelo, iMEI, memoria);

                    do
                    {
                        opcaoUsuario = motorola.MenuEOpcaoUsuario();

                        switch (opcaoUsuario)
                        {
                            case 'L':
                                motorola.Ligar();
                                break;

                            case 'R':
                                motorola.RecebeLigacao();
                                break;

                            case 'I':
                                Console.Write("\nQual Aplicativo deseja baixar: ");
                                nome = Console.ReadLine();
                                motorola.InstalarAplicativo(nome);
                                break;

                            case 'C':
                                motorola.Configuracao();
                                break;

                            case 'S':
                                break;
                        }

                    } while (opcaoUsuario != 'S');

                    break;

                case 'I':
                    numero = "(99) 98765-4321";
                    modelo = "iPhone 14 Pro Max";
                    iMEI = "999999-99-999999-9";
                    memoria = 500;
                    Iphone iphone = new Iphone(numero, modelo, iMEI, memoria);

                    do
                    {
                        opcaoUsuario = iphone.MenuEOpcaoUsuario();

                        switch (opcaoUsuario)
                        {
                            case 'L':
                                iphone.Ligar();
                                break;

                            case 'R':
                                iphone.RecebeLigacao();
                                break;

                            case 'I':
                                Console.Write("\nQual Aplicativo deseja baixar: ");
                                nome = Console.ReadLine();
                                iphone.InstalarAplicativo(nome);
                                break;

                            case 'C':
                                iphone.Configuracao();
                                break;

                            case 'S':
                                break;
                        }

                    } while (opcaoUsuario != 'S');

                    break;
            }
        }
    }
}
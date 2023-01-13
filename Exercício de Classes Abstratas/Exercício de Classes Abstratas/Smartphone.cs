using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Classes_Abstratas
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.Clear();
            Console.WriteLine("Ligando...\n");
            Thread.Sleep(2000);
            Console.WriteLine("Ligação Realizada Com Sucesso");
            Thread.Sleep(1500);
        }

        public void RecebeLigacao()
        {
            Console.Clear();
            Console.WriteLine("Recebendo Ligação...\n");
            Thread.Sleep(2000);
            Console.WriteLine("Ligação Recebida Com Sucesso");
            Thread.Sleep(1500);
        }

        public abstract void InstalarAplicativo(string nome);
        
        public char MenuEOpcaoUsuario()
        {
            Console.Clear();
            Console.WriteLine("MENU SMARTPHONE\n");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("L - Ligar");
            Console.WriteLine("R - Receber Ligação");
            Console.WriteLine("I - Instalar APP");
            Console.WriteLine("C - Configurações");
            Console.WriteLine("S - Sair");

            Console.Write("\nDigite uma das opções acima: ");
            char opcaoUsuario;
            do
            {
                char.TryParse(Console.ReadLine().ToUpper(), out opcaoUsuario);

                if (opcaoUsuario != 'L' && opcaoUsuario != 'R' && opcaoUsuario != 'I' && opcaoUsuario != 'S' && opcaoUsuario != 'C')
                {
                    Console.WriteLine("Opção Invalida\n");
                    Console.Write("Digite uma das opções (L, R, I, C ou S): ");
                }

            } while (opcaoUsuario != 'L' && opcaoUsuario != 'R' && opcaoUsuario != 'I' && opcaoUsuario != 'S' && opcaoUsuario != 'C');

            return opcaoUsuario;
        }

        public void Configuracao()
        {
            Console.Clear();
            Console.WriteLine("Configurações\n");
            Console.WriteLine("Numero: " + Numero);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("IMEI: " + IMEI);
            Console.WriteLine($"Memoria: {Memoria}GB");
            Console.WriteLine("\nDe Enter Para Voltar Ao Menu");
            Console.ReadLine();
        }

    }
}

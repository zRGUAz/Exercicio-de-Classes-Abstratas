using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Classes_Abstratas
{
    public class Motorola : Smartphone
    {
        public Motorola(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria) { }


        public override void InstalarAplicativo(string nome)
        {
            Console.Clear();
            Console.WriteLine($"Instalando {nome} na Play Store...\n");
            Thread.Sleep(2000);
            Console.WriteLine(nome + " Instalado com Sucesso");
            Thread.Sleep(1500);
        }
    }
}

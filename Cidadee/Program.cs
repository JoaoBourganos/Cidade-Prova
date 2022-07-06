using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cidades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string EX = null;
            int codigo, dia, ano, mes;
            string dataAtual;
            Console.WriteLine("1 – Atibaia\t2 – Bragança Paulista\t3 – Mairiporã\t4 – Nazaré\t5 – Terra Preta\t6 – Extrema\t7 – Vargem ");
            Console.WriteLine("Digite o código da cidade: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a data 00/00/0000: ");
            var dA = Convert.ToDateTime(Console.ReadLine());
            dia = dA.Day;
            mes = dA.Month;
            ano = dA.Year;


            switch (mes)
            {
                case 01:
                    EX = "Janeiro";
                    break;
                case 02:
                    EX = "Fevereiro";
                    break;
                case 03:
                    EX = "Março";
                    break;
                case 04:
                    EX = "Abril";
                    break;
                case 05:
                    EX = "Maio";
                    break;
                case 06:
                    EX = "Junho";
                    break;
                case 07:
                    EX = "Julho";
                    break;
                case 08:
                    EX = "Agosto";
                    break;
                case 09:
                    EX = "Setembro";
                    break;
                case 10:
                    EX = "Outubro";
                    break;
                case 11:
                    EX = "Novembro";
                    break;
                case 12:
                    EX = "Dezembro";
                    break;
            }

            dataAtual = dia + " de " + EX + " de " + ano;

            if (codigo == 1)
            {
                Console.WriteLine("Atibaia, " + dataAtual);
            }
            if (codigo == 2)
            {
                Console.WriteLine("Bragança Paulista, " + dataAtual);
            }
            if (codigo == 3)
            {
                Console.WriteLine("Mairiporã, " + dataAtual);
            }
            if (codigo == 4)
            {
                Console.WriteLine("Nazaré, " + dataAtual);
            }
            if (codigo == 5)
            {
                Console.WriteLine("Terra Preta, " + dataAtual);
            }
            if (codigo == 6)
            {
                Console.WriteLine("Extrema, " + dataAtual);
            }
            if (codigo == 7)
            {
                Console.WriteLine("Vargem, " + dataAtual);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario gisele = new Funcionario();

            gisele.Nome = "Gisele";
            gisele.CPF = "045.224.429.39";
            gisele.Salario = 2000;

            Console.WriteLine(gisele.Nome);
            Console.WriteLine(gisele.ObterBonificacao());
            Console.ReadLine();

        }
    }
}

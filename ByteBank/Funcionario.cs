using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Funcionario
    {

        public String Nome { get; set; }
        public String CPF { get; set; }
        public double Salario { get; set; }

        public double ObterBonificacao() {
            
            return Salario * 0.10;
        }
    }
}

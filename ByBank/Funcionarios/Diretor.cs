using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBank.Funcionarios
{
    internal class Diretor : Funcionario
    {
        /*public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }*/

        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBank.Funcionarios
{
    internal class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Auxiliar criado!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.020;
        }
    }
}

using ByBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBank.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Gerente de conta criado!");
        }

        public override void AumentarSalario()
        {
            Console.WriteLine("Atenção não esqueca de sobrescrever o método aumentar salário");
        }

        public override double GetBonificacao()
        {
            Console.WriteLine("Atenção não esqueca de sobrescrever o método aumentar salário");
            return Salario * 0.25;
        }
    }
}

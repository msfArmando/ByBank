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

        public Diretor(string cpf) : base(5000, cpf) //No momento que eu to chamando o construtor da classe base to passando adiante o argumento cpf
        {                                      //Passa argumentos pra classe base 
            Console.WriteLine("Criando diretor!"); //O : vai chamar a base (funcionário) os dois pontos dizem que construtor diretor vai chamar o construtor
        }                                          //Da classe base antes de tudo

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario*0.5;
        }
    }
}

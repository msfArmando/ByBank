using ByBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor eduarda = new Diretor();
            eduarda.Nome = "Eduarda";
            eduarda.CPF = "154.456.457-51";
            eduarda.Salario = 3000;

            Funcionario eduardateste = eduarda;

            gerenciador.Registrar(eduarda);
            Console.WriteLine("Bonificação de Duda(Diretora)");
            Console.WriteLine(eduarda.GetBonificacao());
            Console.WriteLine("Bonificação de Duda(Funcionária)");
            Console.WriteLine(eduardateste.GetBonificacao());

            Funcionario joshua = new Funcionario();
            joshua.Nome = "Joshua";
            joshua.CPF = "354.156.458-52";
            joshua.Salario = 1500;

            gerenciador.Registrar(joshua);
            Console.WriteLine("Bonificação de Joshua");
            Console.WriteLine(joshua.GetBonificacao());

            Console.WriteLine("Total de bonificações");
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            //joshua.Teste(1, 2);

            Console.ReadLine();
        }
    }
}

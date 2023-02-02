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
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            
            Designer pedro = new Designer("154.654.263-15");
            pedro.Nome = "Pedro";

            Diretor gustavo = new Diretor("654.178.564-87");
            gustavo.Nome = "Gustavo";

            Auxiliar cleiton = new Auxiliar("651.684.123-78");
            cleiton.Nome = "Cleiton";

            GerenteDeConta armando = new GerenteDeConta("111.632.395 - 15");
            armando.Nome = "Armando";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(gustavo);
            gerenciadorBonificacao.Registrar(cleiton);
            gerenciadorBonificacao.Registrar(armando);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}

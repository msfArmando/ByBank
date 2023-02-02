using ByBank.Funcionarios;
using ByBank.Sistemas;
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
            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno= new SistemaInterno();
            Diretor gustavo = new Diretor("654.178.564-87");
            gustavo.Nome = "Gustavo";
            gustavo.Senha = "154";

            Designer pedro = new Designer("154.654.263-15");
            pedro.Nome = "Pedro";

            GerenteDeConta armando = new GerenteDeConta("111.632.395 - 15");
            armando.Nome = "Armando";
            armando.Senha = "541";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "1547");
            sistemaInterno.Logar(gustavo, "154");
            sistemaInterno.Logar(armando, "541");

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

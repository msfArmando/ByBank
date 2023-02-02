using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf) 
        {
            Console.WriteLine("Criando funcionário");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf)
        {
            TotalDeFuncionarios++;
            CPF = cpf;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        /*public void Teste(double a, int b)
        {
            Console.WriteLine("Teste(double, int)");
        }
        public void Teste(int a, double b)
        {
            Console.WriteLine("Teste(int, double)");
        }*/

        public static int TotalFuncionarios { get; private set; }
    }
}

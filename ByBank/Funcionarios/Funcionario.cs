﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        /*public void Teste(double a, int b)
        {
            Console.WriteLine("Teste(double, int)");
        }
        public void Teste(int a, double b)
        {
            Console.WriteLine("Teste(int, double)");
        }*/
    }
}
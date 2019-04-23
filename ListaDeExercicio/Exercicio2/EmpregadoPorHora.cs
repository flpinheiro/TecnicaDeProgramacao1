using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class EmpregadoPorHora :Empregado
    {
        public int Horas { get; set; }

        public override double CalculaSalario()
        {
            return Salario + Horas * 15;
        }

    }
}

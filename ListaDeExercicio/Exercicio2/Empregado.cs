using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    abstract class Empregado
    {
        public float Salario{ get; set; }

        public abstract double CalculaSalario();
    }
}

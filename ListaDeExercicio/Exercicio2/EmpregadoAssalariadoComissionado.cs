using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class EmpregadoAssalariadoComissionado : EmpregadoComissionado
    {
        public override double CalculaSalario()
        {
            return Salario + base.CalculaSalario();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class EmpregadoAssalariado: Empregado
    {
        public override double CalculaSalario()
        {
            return Salario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class EmpregadoComissionado : Empregado
    {
        public float TaxaDeVendas {get; set;}
        public float Vendas { get; set; }

        public override double CalculaSalario()
        {
            return TaxaDeVendas * Vendas;
        }
    }
}

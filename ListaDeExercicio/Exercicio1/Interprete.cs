using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Interprete : Artista
    {
        public Interprete(string nome, string nacionalidade) : base(nome, nacionalidade) { }
        public void Canta() { }
    }
}

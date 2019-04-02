using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Autor : Artista
    {
        public Autor(string nome, string nacionalidade) : base(nome,nacionalidade){ }
        public void Escreve() { }
    }
}

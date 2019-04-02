using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Album : IComparable
    {
        private List<Musica> ListaDeMusica;
        private List<Interprete> ListaDeInterprete;
        public string Nome { get;  }
        public DateTime AnoDeLancamento { get; }
        private char _sorteTipo;

        public Album(string nome, DateTime anoDeLancamento)
        {
            Nome = nome;
            AnoDeLancamento = anoDeLancamento;
            ListaDeMusica = new List<Musica>();
            ListaDeInterprete = new List<Interprete>();
            _sorteTipo = 'n';//padrão
        }

        public void SortByNome()
        {
            _sorteTipo = 'n';
        }

        public void SortByAnoDeLancamento()
        {
            _sorteTipo = 'd';
        }

        public int CompareTo(object obj)
        {
            switch (_sorteTipo)
            {
                case 'd':
                    return AnoDeLancamento.CompareTo(obj);
                case 'n':
                default:
                    return Nome.CompareTo(obj);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Musica : IComparable
    {
        private List<Artista> ListaDeArtista;
        public string Nome { get; }
        public int Duracao { get; }
        private char _sortTipo;

        public Musica(string nome, int duracao)
        {
            Nome = nome;
            Duracao = duracao;
            ListaDeArtista = new List<Artista>();
            _sortTipo = 'n';//padrao é fazer o sorte por nome por nome;
        }

        public void AddArtista(Artista a)
        {
            ListaDeArtista.Add(a);
        }

        public void SortByNome()
        {
            _sortTipo = 'n';
        }

        public void SortByDuracao()
        {
            _sortTipo = 'd';
        }

        public int CompareTo(object obj)
        {
            switch (_sortTipo)
            { 
                case 'd':
                    return Duracao.CompareTo(obj);
                case 'n':
                default:
                    return Nome.CompareTo(obj);
            }
            
        }
    }
}

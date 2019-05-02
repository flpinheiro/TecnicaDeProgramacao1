using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    abstract class Artista : IComparable
    {
        public string Nome { get; private set; }
        public string Nacionalidade { get; private set; }
        private List<Musica> ListaDeMusica;
        private List<Album> ListaDeAlbum;
        private char _sortTipo;

        public Artista(string nome, string nacionalidade)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            ListaDeAlbum = new List<Album>();
            ListaDeMusica = new List<Musica>();
            _sortTipo = 'n';//padrão nome
        }

        public void Publica(Musica musica, Album album)
        {
            ListaDeMusica.Add(musica);
            ListaDeAlbum.Add(album);
        }

        public void SortByNome()
        {
            _sortTipo = 'n';
        }

        public void SortByNacionalidade()
        {
            _sortTipo = 'N';
        }

        public int CompareTo(object obj)
        {
            switch (_sortTipo)
            {
                case 'N':
                    return Nacionalidade.CompareTo(obj);
                case 'n':
                default:
                    return Nome.CompareTo(obj);
            }
        }
    }
}

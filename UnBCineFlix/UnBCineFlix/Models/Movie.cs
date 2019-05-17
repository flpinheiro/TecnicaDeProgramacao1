using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// Class Movie -> define um Filme a ser exibido no Cinema
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Id do filme no sistema de banco de dados
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// titulo do filme
        /// </summary>
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Data de lançamento
        /// </summary>
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        //[Range(1, 100)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal Price { get; set; }

        /// <summary>
        /// Genero do Filme
        /// </summary>
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        /// <summary>
        /// Classificação indicativa
        /// </summary>
        [Required]
        public Rating Rating { get; set; }

        /// <summary>
        /// duração do filme. 
        /// </summary>
        [DataType(DataType.Duration)]
        [Required]
        public int Duration { get; set; }

        /// <summary>
        /// Sinopse do filme
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Required]
        public string Synopsis { get; set; }

        /// <summary>
        /// Lista de artistas que participaram do filme
        /// </summary>
        public List<Artist> ArtistList;

        /// <summary>
        /// Lista de diretores que participaram do filme
        /// </summary>
        public List<Artist> DirectorList;

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Movie()
        {
            ArtistList = new List<Artist>();
            DirectorList = new List<Artist>();
        }

        /// <summary>
        /// Converte o Movie para uma string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var ret = new StringBuilder();
            ret.AppendLine(Title);
            ret.AppendLine($"{ReleaseDate.Year}, {Genre} - {Rating}");
            ret.AppendLine(Synopsis);
            ret.Append("Estrelando");
            foreach (var artist in ArtistList)
            {
                if (artist !=null)
                {
                    ret.Append($" - {artist.Name} ");
                }
            }
            ret.AppendLine();
            ret.Append("Dirigido por");
            foreach (var director in  DirectorList)
            {
                if (director != null)
                {
                    ret.Append($" - {director.Name} ");
                }
            }
            return ret.ToString();
        }
    }
}
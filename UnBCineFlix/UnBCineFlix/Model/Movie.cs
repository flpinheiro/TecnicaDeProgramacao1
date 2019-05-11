using System;
using System.ComponentModel.DataAnnotations;
namespace UnBCineFlix.Model
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
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        /// <summary>
        /// duração do filme. 
        /// </summary>
        [DataType(DataType.Duration)]
        public int Duration { get; set; }

        /// <summary>
        /// Sinopse do filme
        /// </summary>
        [DataType(DataType.MultilineText)]
        public string Synopsis { get; set; }

    }
}
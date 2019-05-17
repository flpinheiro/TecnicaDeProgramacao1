using System;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// classe Session -> define uma sessão de cinema
    /// </summary>
    public class Session
    {
        /// <summary>
        /// id da sessão no sistema de banco de dados
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Dia e hora da sessão do filme
        /// </summary>
        [Display(Name = "Session Day Time")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime SessionDay { get; set; }

        /// <summary>
        /// Sala na qual a sessão irá acontecer
        /// </summary>
        [Required]
        [DataType(DataType.Custom)]
        public MovieTheater MovieTheater { get; set; }
        /// <summary>
        /// Filme a ser exibido na sessão
        /// </summary>
        [Required]
        [DataType(DataType.Custom)]
        public Movie Movie { get; set; }
    }
}

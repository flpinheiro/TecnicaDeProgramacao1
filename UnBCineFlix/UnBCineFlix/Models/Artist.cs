using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// Classe Artist -> define um artista que participa de um filme, ou um diretor.
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// identificação do artista no banco de dados
        /// </summary>
        [Key]
        public int Id { get; }

        /// <summary>
        /// Nome do artista
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        
        /// <summary>
        /// Data de nascimento do artista
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Artist()
        {

        }
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="name">Nome do artista</param>
        public Artist(string name)
        {
            Name = name;
        }

    }
}

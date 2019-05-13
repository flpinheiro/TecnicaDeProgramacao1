using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnBCineFlix.Model
{
    /// <summary>
    /// Classe Address -> define uma classe de endreço pessoal
    /// </summary>
    public class Address
    {
        /// <summary>
        /// identificador da classe no banco de dados
        /// </summary>
        [Key]
        [Required]
        public int Id { get;  }

        [Required]
        public string Country { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string District { get; set; }


        public string Complement { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}

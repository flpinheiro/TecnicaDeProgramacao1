using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnBCineFlix.Models
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
        /// <summary>
        /// Pais no qual o endereço está localizado
        /// </summary>
        [Required]
        [MaxLength(100), MinLength(3)]
        public string Country { get; set; }
        /// <summary>
        /// Estado no qual o endereço está localizado
        /// </summary>
        [Required]
        [MaxLength(100), MinLength(3)]
        public string State { get; set; }
        /// <summary>
        /// Cidade no qual o endereço está localizado
        /// </summary>
        [Required]
        [MaxLength(100), MinLength(3)]
        public string City { get; set; }
        /// <summary>
        /// Bairro no qual o endreço está localizado
        /// </summary>
        [Required]
        [MaxLength(100), MinLength(3)]
        public string District { get; set; }

        /// <summary>
        /// Complementos do endereço
        /// </summary>
        [MaxLength(255), MinLength(3)]
        public string Complement { get; set; }

        /// <summary>
        /// Numero da rua do endereço
        /// </summary>
        [Required]
        public int Number { get; set; }
        /// <summary>
        /// Cep do endereço
        /// </summary>
        [Required]
        public int ZipCode { get; set; }

        /// <summary>
        /// Rua na qual o endereço está localizado
        /// </summary>
        [Required]
        [MaxLength(100), MinLength(3)]
        public string Street { get; set; }

        public Address()
        {

        }
    }
}

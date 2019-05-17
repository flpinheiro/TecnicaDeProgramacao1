using System;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// Classe Client -> Define um cliente na aplicação
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Email do Cliente
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// Senha do cliente
        /// </summary>
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

    }
}

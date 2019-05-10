using System;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Model
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
        public string Email { get; set; }
        /// <summary>
        /// Senha do cliente
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// Employee -> Define um empregado
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// matricula do empregado
        /// </summary>
        [Required]
        public int Cod { get; set; }

        /// <summary>
        /// password do empregado
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// Classe Person -> define uma classe abstrata de pessoa
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// identificador único de pessoa no banco de dados
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Nome de uma pessoa
        /// </summary>
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// CPF de pessoa
        /// </summary>
        [Required]
        public int CPF { get; set; }

        /// <summary>
        /// telefone da pessoa
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        public int TelePhone { get; set; }
        /// <summary>
        /// Data de aniversário da pessoa
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        public List<Address> AddressList;

        public Person()
        {
            AddressList = new List<Address>();
        }

    }
}

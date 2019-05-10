using System;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Model
{
    /// <summary>
    /// Classe Chair-> Define uma cadeira de cinema com colunas e fileiras
    /// </summary>
    public class Chair
    {
        /// <summary>
        /// identificação da cadeira no banco de dados
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Coluna da cadeira no cinema
        /// </summary>
        [Required]
        public int Column { get; set; }
        /// <summary>
        /// fileira da cadeira no cinema
        /// </summary>
        [Required]
        public int Row { get; set; }

        /// <summary>
        /// status da cadeira na sessão do cinema
        /// true  ->     vendido
        /// false -> não vendido
        /// </summary>
        [Required]
        public bool Status { get; set; }
    }
}

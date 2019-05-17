using System;
using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Models
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

        /// <summary>
        /// Construtor padrão para Chair
        /// </summary>
        /// <param name="row">Número da fileira da cadeira</param>
        /// <param name="column">Número da coluna da cadeira</param>
        /// <param name="status">Status da cadeira, true:vendida, false:não vendia(valor padrão)</param>
        public Chair(int row, int column, bool status = false)
        {
            if (row<0||column<0)
            {
                throw new ArgumentException("O número da fileira da cadeira ou da coluna da cadeira não pode ser negativo");
            }
            Row = row;
            Column = column;
            Status = status;
        }
    }
}

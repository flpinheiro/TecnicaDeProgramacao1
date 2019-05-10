using System.ComponentModel.DataAnnotations;

namespace UnBCineFlix.Model
{
    /// <summary>
    /// Classe MovieTheater -> define uma sala de cinema
    /// </summary>
    public class MovieTheater
    {
        /// <summary>
        /// Id da sala de cinema no banco de dados
        /// </summary>
        [KeyAttribute]
        public int Id { get; set; }
        /// <summary>
        /// Numero da sala de cinema
        /// </summary>
        [Required]
        public int Number { get; set; }
    }
}

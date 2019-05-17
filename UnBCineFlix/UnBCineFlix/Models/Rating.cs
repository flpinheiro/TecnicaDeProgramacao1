using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnBCineFlix.Models
{
    /// <summary>
    /// G – General Audiences - All ages admitted.Nothing that would offend parents for viewing by children.
    /// PG – Parental Guidance Suggested - Some material may not be suitable for children.Parents urged to give "parental guidance". May contain some material parents might not like for their young children.
    /// PG-13 – Parents Strongly Cautioned - Some material may be inappropriate for children under 13. Parents are urged to be cautious.Some material may be inappropriate for pre-teenagers.
    /// R – Restricted - Under 17 requires accompanying parent or adult guardian. Contains some adult material. Parents are urged to learn more about the film before taking their young children with them.
    /// NC-17 – Adults Only - No One 17 and Under Admitted.Clearly adult. Children are not admitted.
    /// Versão em portugues BR
    /// Livre
    /// NR 10 - não recomendado para menores de 10 anos
    /// NR 12 - Não recomendado para menores de 12 anos
    /// NR 14 - Não recomendado para menores de 14 anos
    /// NR 16 - Não recomendado para menores de 16 anos
    /// NR 18 - Não recomendado para menores de 18 anos.
    /// </summary>
    public class Rating
    {
        [Key]
        public int Id { get; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Name { get; }

        [Required]
        public int Age { get; }

        public Rating(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

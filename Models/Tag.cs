using System.ComponentModel.DataAnnotations;

namespace SwaggerExample.Models
{
    /// <summary>
    /// Хараткеристика животного
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Идентификатор харатктеристики
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Наименование характеристики
        /// </summary>
        [Required(ErrorMessage = "Не указана кличка")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Длина наименования характеристики должна быть от 3 до 150 символов")]
        public string Name { get; set; }
    }
}

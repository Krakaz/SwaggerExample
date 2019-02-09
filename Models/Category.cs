using System.ComponentModel.DataAnnotations;

namespace SwaggerExample.Models
{
    /// <summary>
    /// Категория домашнего животного
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Наименование категории
        /// </summary>
        [Required(ErrorMessage = "Поле наименования обязательно для заполнения")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Длина наименования категории должна быть от 3 до 200 символов")]
        public string Name { get; set; }
    }
}

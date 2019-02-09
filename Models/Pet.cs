using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SwaggerExample.Models.Enums;

namespace SwaggerExample.Models
{
    /// <summary>
    /// Модель домашнего животного
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// Идентификатор животного
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Категория животного
        /// </summary>
        [Required(ErrorMessage = "Не указана категория")]
        public Category Category { get; set; }

        /// <summary>
        /// Кличка животного
        /// </summary>
        [Required(ErrorMessage = "Не указана кличка")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина клички животного должна быть от 3 до 50 символов")]
        public string Name { get; set; }

        /// <summary>
        /// Возраст животного
        /// </summary>
        [Range(0, 110, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        /// <summary>
        /// Телефон владельца
        /// </summary>
        [Phone]
        public string Phone { get; set; }

        /// <summary>
        /// Ссылки на фото
        /// </summary>
        [DataType(DataType.ImageUrl, ErrorMessage = "Не корректная ссылка на изображение")]
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// Список характеристик
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        [Required(ErrorMessage = "Не указан статус")]
        [EnumDataType(typeof(Statuses))]
        public Statuses Status { get; set; }
    }
}

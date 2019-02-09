using System.Collections.Generic;
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
        public int Id { get; set; }

        /// <summary>
        /// Категория животного
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Кличка животного
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ссылки на фото
        /// </summary>
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// Список характеристик
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public Statuses Status { get; set; }
    }
}

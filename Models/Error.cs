using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerExample.Models
{
    /// <summary>
    /// Модель ошибки
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Код ошибки
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Сообщение для пользователя
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Информация о ошибке
        /// </summary>
        public string StakTrace { get; set; }
    }
}

using System.ComponentModel;
using System.Runtime.Serialization;

namespace SwaggerExample.Models.Enums
{
    /// <summary>
    /// Статус животного
    /// </summary>
    public enum Statuses
    {
        /// <summary>
        /// Доступен
        /// </summary>
        [Description("Доступен")]
        [EnumMember(Value = "available")]
        Available = 1,

        /// <summary>
        /// Продан
        /// </summary>
        [Description("Продан")]
        [EnumMember(Value = "solded")]
        Solded = 2,

        /// <summary>
        /// Ожидается
        /// </summary>
        [Description("Ожидается")]
        [EnumMember(Value = "expected")]
        Expected = 3,
    }
}

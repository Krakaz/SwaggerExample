using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SwaggerExample.Models;
using SwaggerExample.Models.Enums;

namespace SwaggerExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly List<Pet> pets = new List<Pet>
        {
                new Pet { Id = 1, Name = "Снуппи", Category = new Category { Id = 1, Name = "Сиамский кот" }, Status = Statuses.Available, Tags = new List<Tag> { new Tag { Id = 1, Name = "Ласковый" }, new Tag { Id = 2, Name = "Игривый" } } },
                new Pet { Id = 2, Name = "Персиваль", Category = new Category { Id = 5, Name = "Ласка" }, Status = Statuses.Expected, Tags = new List<Tag> { new Tag { Id = 10, Name = "Очень активный" }, new Tag { Id = 2, Name = "Игривый" } } }
            };

        /// <summary>
        /// Запрашивает список всех животных
        /// </summary>
        /// <returns>Возвращает список всех животных</returns>
        /// <response code="200">Возвращает список всех животных</response>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            return pets;
        }

        // GET api/values/5

        /// <summary>
        /// Получает информацию по животному по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор животного</param>
        /// <returns>Возвращает животное по идентификатору</returns>
        /// <response code="200">Возвращает животное по идентификатору</response>
        /// <response code="404">Если животное отсутствует</response>
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 404)]
        public ActionResult<Pet> Get(int id)
        {
            var pet = pets.SingleOrDefault(el => el.Id == id);
            if (pet == null)
            {
                return NotFound(new Error { Code = 404, ErrorMessage = "Животное отсутствует в БД" });
            }

            return Ok(pet);
        }

        // POST api/values

        /// <summary>
        /// Добавляет нового животного
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     {
        ///       "id": 1,
        ///       "category": {
        ///         "id": 1,
        ///         "name": "Сиамский кот"
        ///       },
        ///       "name": "doggie",
        ///       "age": "1",
        ///       "photoUrls": [
        ///         "https://cs9.pikabu.ru/post_img/big/2017/02/16/10/1487262267154872190.jpg"
        ///       ],
        ///       "tags": [
        ///         {
        ///           "id": 1,
        ///           "name": "Ласковый"
        ///         }
        ///       ],
        ///       "status": "available"
        ///     }
        ///
        /// </remarks>
        /// <param name="value"></param>
        /// <returns>Новая созданная модель животного</returns>
        /// <response code="201">Возвращает новую созданную модель</response>
        /// <response code="400">Если модель пуста</response>   
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(201)]
        [ProducesResponseType(typeof(Error), 400)]
        public ActionResult<Pet> Post([FromBody] Pet value)
        {
            value.Id = 100;
            return value;
        }

        // PUT api/values/5

        /// <summary>
        /// Изменияе существующего животного
        /// </summary>
        /// <param name="id">Идентификатор животного</param>
        /// <param name="value"></param>
        /// <returns>Возвращает измененную модель животного</returns>
        /// <response code="200">Возвращает измененную модель</response>
        /// <response code="400">Если модель пуста</response>   
        [HttpPut("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 400)]
        public ActionResult<Pet> Put(int id, [FromBody] Pet value)
        {
            return value;
        }

        // DELETE api/values/5

        /// <summary>
        /// Удаляет животное из системы
        /// </summary>
        /// <param name="id">Идентификатор животного</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public void Delete(int id)
        {
        }
    }
}

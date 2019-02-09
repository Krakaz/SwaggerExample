using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerExample.Models;
using SwaggerExample.Models.Enums;

namespace SwaggerExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly List<Pet> pets = new List<Pet> {
                new Pet { Id = 1, Name = "Снуппи", Category = new Category { Id = 1, Name = "Сиамский кот" }, Status = Statuses.Available, Tags = new List<Tag> { new Tag { Id = 1, Name = "Ласковый" }, new Tag { Id = 2, Name = "Игривый"} } },
                new Pet { Id = 2, Name = "Персиваль", Category = new Category { Id = 5, Name = "Ласка" }, Status = Statuses.Expected, Tags = new List<Tag> { new Tag { Id = 10, Name = "Очень активный" }, new Tag { Id = 2, Name = "Игривый"} } }
            };

        /// <summary>
        /// Запрашивает список всех животных
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            return pets;
        }

        // GET api/values/5
        /// <summary>
        /// Получает информацию по животному по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор животного</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            return pets.SingleOrDefault(el => el.Id == id);
        }

        // POST api/values
        /// <summary>
        /// Добавляет нового животного
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] Pet value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Изменияе существующего животного
        /// </summary>
        /// <param name="id">Идентификатор животного</param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pet value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Удаляет животное из системы
        /// </summary>
        /// <param name="id">Идентификатор животного</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

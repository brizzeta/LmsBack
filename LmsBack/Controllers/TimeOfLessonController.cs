using LmsBack.Model;
using LmsBack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LmsBack.Controllers {
    [ApiController]
    [Route("api/TimeOfLesson")]
    public class TimeOfLessonController : ControllerBase {
        private readonly IRepository<TimeOfLesson> rep;
        public TimeOfLessonController(IRepository<TimeOfLesson> r) => rep = r;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimeOfLesson>>> Get() => Ok(await rep.GetAll());
        [HttpGet("{id}")]
        public async Task<ActionResult<TimeOfLesson>> GetOne(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var entity = await rep.GetById(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
        [HttpPost]
        public async Task<ActionResult<TimeOfLesson>> Add(TimeOfLesson entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Insert(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpPut]
        public async Task<ActionResult<TimeOfLesson>> Edit(TimeOfLesson entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            rep.Update(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TimeOfLesson>> Delete(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Delete(id);
            await rep.Save();
            return Ok(await rep.GetById(id));
        }
    }
}
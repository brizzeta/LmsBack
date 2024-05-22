using LmsBack.Model;
using LmsBack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LmsBack.Controllers {
    [ApiController]
    [Route("api/LessonMark")]
    public class LessonMarkController : ControllerBase {
        private readonly IRepository<LessonMark> rep;
        public LessonMarkController(IRepository<LessonMark> r) => rep = r;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LessonMark>>> Get() => Ok(await rep.GetAll());
        [HttpGet("{id}")]
        public async Task<ActionResult<LessonMark>> GetOne(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var entity = await rep.GetById(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
        [HttpPost]
        public async Task<ActionResult<LessonMark>> Add(LessonMark entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Insert(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpPut]
        public async Task<ActionResult<LessonMark>> Edit(LessonMark entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            rep.Update(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<LessonMark>> Delete(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Delete(id);
            await rep.Save();
            return Ok(await rep.GetById(id));
        }
    }
}
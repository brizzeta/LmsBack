using LmsBack.Model;
using LmsBack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LmsBack.Controllers {
    [ApiController]
    [Route("api/HomeworkStudent")]
    public class HomeworkStudentController : ControllerBase {
        private readonly IRepository<HomeworkStudent> rep;
        public HomeworkStudentController(IRepository<HomeworkStudent> r) => rep = r;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeworkStudent>>> Get() => Ok(await rep.GetAll());
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeworkStudent>> GetOne(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var entity = await rep.GetById(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
        [HttpPost]
        public async Task<ActionResult<HomeworkStudent>> Add(HomeworkStudent entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Insert(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpPut]
        public async Task<ActionResult<HomeworkStudent>> Edit(HomeworkStudent entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            rep.Update(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<HomeworkStudent>> Delete(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Delete(id);
            await rep.Save();
            return Ok(await rep.GetById(id));
        }
    }
}
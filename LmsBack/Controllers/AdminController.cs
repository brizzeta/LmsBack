using LmsBack.Model;
using LmsBack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LmsBack.Controllers {
    [ApiController]
    [Route("api/Admin")]
    public class AdminController : ControllerBase {
        private readonly IRepository<Admin> rep;
        public AdminController(IRepository<Admin> r) => rep = r;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> Get() => Ok(await rep.GetAll());
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetOne(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var entity = await rep.GetById(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
        [HttpPost]
        public async Task<ActionResult<Admin>> Add(Admin entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Insert(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpPut]
        public async Task<ActionResult<Admin>> Edit(Admin entity)  {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            rep.Update(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Admin>> Delte(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Delete(id);
            await rep.Save();
            return Ok(await rep.GetById(id));
        }
    }
}
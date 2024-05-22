using LmsBack.Model;
using LmsBack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LmsBack.Controllers {
    [ApiController]
    [Route("api/Account")]
    public class AccountController : ControllerBase {
        private readonly IRepository<Account> rep;
        public AccountController(IRepository<Account> r) => rep = r;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> Get() => Ok(await rep.GetAll());
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetOne(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var entity = await rep.GetById(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
        [HttpPost]
        public async Task<ActionResult<Account>> Add(Account entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Insert(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpPut]
        public async Task<ActionResult<Account>> Edit(Account entity) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            rep.Update(entity);
            await rep.Save();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> Delete(int id) {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await rep.Delete(id);
            await rep.Save();
            return Ok(await rep.GetById(id));
        }
    }
}
using LmsBack.Model;
using LmsBack.Models;
using LmsBack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LmsBack.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase {
        private readonly Context db;
        private readonly ICryptography cryptography;
        public AuthController(Context context, ICryptography crypt) {
            db = context;
            cryptography = crypt;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginVM model) {
            var account = db.Accounts.SingleOrDefault(a => a.Login == model.Login);
            if (account == null) return Unauthorized("Неверный логин или пароль.");
            string hashedPassword = cryptography.HashPassword(model.Password!, account.Salt!);
            if (hashedPassword != account.Password) return Unauthorized("Неверный логин или пароль.");
            var admin = db.Admins.SingleOrDefault(a => a.Id == account.Id);
            if (admin == null) return Unauthorized("Админ не найден.");

            return Ok(new {
                admin.Name,
                admin.Surname,
                admin.Email
            });
        }
    }
}
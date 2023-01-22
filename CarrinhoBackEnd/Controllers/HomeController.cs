using CarrinhoBackEnd.Models;
using CarrinhoBackEnd.Repository;
using CarrinhoBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarrinhoBackEnd.Controllers
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] LogUserDTo model)
        {
            Console.WriteLine("Tentativa de Login de: " + model.Email);
            
            var user = UserRepository.Get(model.Email, model.Password);

            if (user == null)
                return NotFound(new { message = "User not found" });

            var token = TokenService.GenerateToken(user);
            
            return new
            {
                Email = user.Email,
                Role = user.Role,
                token = token
            };

        }

       [HttpPost]
       [Route("/register")]
       public async Task<ActionResult<dynamic>> CreateUser([FromBody] User newUser)
        {

            try
            {
                UserRepository.AddUser(newUser);
                return Ok("Usuário criado com sucesso!");
            }
            catch
            {
                return StatusCode(500);
            }
            
        }

    }
}

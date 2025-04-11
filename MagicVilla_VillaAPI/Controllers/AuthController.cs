using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        public AuthController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            if (loginDTO == null || string.IsNullOrEmpty(loginDTO.Username) || string.IsNullOrEmpty(loginDTO.Password))
            {
                return BadRequest("Invalid login request");
            }
            var user = _db.Users.FirstOrDefault(u => u.Username.ToLower() == loginDTO.Username.ToLower() && u.Password == loginDTO.Password); // not case sensitive for username, but case sensitive for password
            //var userAuth = _db.Users.FirstOrDefault(u => u.IsWebUser);
            if (user == null)
            {
                return Unauthorized();
            }

            if (!user.IsWebUser)
            {
                return Unauthorized("You do not have permission");
            }

            //for loginDTO.Id loginDTO.IsWebUser

            // TODO ** Generate token here
            return Ok(new { Token = "GeneratedToken" });
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<LoginDTO> RegisterUser([FromBody] LoginDTO registerDTO)
        {
            if (_db.Users.FirstOrDefault(u => u.Username.ToLower() == registerDTO.Username.ToLower()) != null)
            {
                ModelState.AddModelError("Custom Error", "Username is already taken");
                return BadRequest(ModelState);
            }    

            if (registerDTO == null)
            {
                return BadRequest(registerDTO);
            }

            if (registerDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            if (_db.Users.FirstOrDefault(u => u.Id == registerDTO.Id) != null)
            {
                ModelState.AddModelError("Custom Error", "User already exists");
                return BadRequest(ModelState);
            }

            User model = new()
            {
                Username = registerDTO.Username,
                Id = registerDTO.Id,
                Password = registerDTO.Password,
                IsWebUser = registerDTO.IsWebUser
            };

            _db.Users.Add(model);
            _db.SaveChanges();
            return CreatedAtRoute("GetUser", new { id = model.Id }, model);

        }
    }
}

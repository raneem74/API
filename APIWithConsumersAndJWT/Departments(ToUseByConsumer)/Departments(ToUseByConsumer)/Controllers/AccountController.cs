using Departments_ToUseByConsumer_.DTO;
using Departments_ToUseByConsumer_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Formats.Tar;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Departments_ToUseByConsumer_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        public AccountController(UserManager<AppUser> usrmanager,IConfiguration configuration)
        {
            Usrmanager = usrmanager;
            Configuration = configuration;
        }
        public UserManager<AppUser> Usrmanager { get; }
        public IConfiguration Configuration { get; }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //sava into DB 

            //create user object and assign his data from DTO 
            AppUser userModel = new AppUser();
            userModel.UserName = registerDTO.Username;
            userModel.Email = registerDTO.Email;

            //create and save the user
            IdentityResult result = await Usrmanager.CreateAsync(userModel, registerDTO.Password);
            if (result.Succeeded)
            {
                return Ok("Accounr Added");
            }
            return BadRequest(result.Errors);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //check if User exists
            AppUser user = await Usrmanager.FindByNameAsync(userDto.Username);
            if (user != null)
            {
                //check if bassword match the username
                bool CorrectPassword = await Usrmanager.CheckPasswordAsync(user, userDto.Password);
                if (CorrectPassword)
                {
                    //claims Token
                    //choose your claim + Jit => unique key for token "string"
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
                    claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

                    //get role
                    var roles = await Usrmanager.GetRolesAsync(user);
                    foreach (var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    //put in teken 

                    //credentials
                    SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]));
                    //it need the used algo and the key
                    SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


                    //create token
                    //design token
                    JwtSecurityToken myToken = new JwtSecurityToken(
                        issuer: Configuration["JWT:ValidIssuer"], // link of Web API 
                        audience: Configuration["JWT:ValidAudience"], // default path for audience // consumer
                        claims: claims,
                        expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signingCredentials
                        );
                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(myToken),
                        expiration = myToken.ValidTo
                    });
                }
            }
            return Unauthorized(); // couldn't be found
                                    
        }
    }
}

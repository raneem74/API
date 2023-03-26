using Microsoft.Build.Framework;

namespace Departments_ToUseByConsumer_.DTO
{
    public class LoginDTO
    {
        
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

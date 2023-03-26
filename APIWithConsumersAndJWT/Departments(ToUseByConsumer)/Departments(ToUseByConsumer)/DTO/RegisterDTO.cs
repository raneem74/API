using Microsoft.Build.Framework;

namespace Departments_ToUseByConsumer_.DTO
{
    public class RegisterDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }

    }
}

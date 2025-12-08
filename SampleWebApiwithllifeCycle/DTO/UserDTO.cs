using System.ComponentModel.DataAnnotations;

namespace SampleWebApiwithllifeCycle.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string? DisplayName { get; set; }
    }

    public class CreateuserDTO
    {
        public required string Email { get; set; }
        public string? DisplayName { get; set; }
    
    }
}

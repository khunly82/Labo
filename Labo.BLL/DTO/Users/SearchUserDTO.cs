using System.ComponentModel.DataAnnotations;

namespace Labo.BLL.DTO.Users
{
    public class SearchUserDTO
    {
        [EmailAddress]
        public string? Email { get; set; }
        public string? Username { get; set; }
        public Guid? ExcludeId { get; set; }
    }
}

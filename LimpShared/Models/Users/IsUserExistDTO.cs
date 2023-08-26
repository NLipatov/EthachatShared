#nullable disable
namespace LimpShared.Models.Users
{
    public record IsUserExistDto
    {
        public string Username { get; set; }
        public bool IsExist { get; set; }
    }
}

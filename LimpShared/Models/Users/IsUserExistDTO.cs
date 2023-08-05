#nullable disable
namespace LimpShared.Models.Users
{
    public record IsUserExistDTO
    {
        public string Username { get; set; }
        public bool IsExist { get; set; }
    }
}

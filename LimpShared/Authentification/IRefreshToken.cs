namespace LimpShared.Authentification
{
    public interface IRefreshToken
    {
        DateTime Created { get; set; }
        DateTime Expires { get; set; }
        string Token { get; set; }
    }
}
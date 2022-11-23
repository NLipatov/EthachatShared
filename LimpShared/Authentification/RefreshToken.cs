namespace LimpShared.Authentification
{
    public class RefreshToken
    {
        DateTime Created { get; set; }
        DateTime Expires { get; set; }
        string Token { get; set; }
    }
}
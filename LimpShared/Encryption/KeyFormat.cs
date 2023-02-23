namespace LimpShared.Encryption;

public enum KeyFormat
{
    Unspecified,
    /// <summary>
    /// Key as a PEM-encoded PKCS #8 object
    /// </summary>
    PEM_PKCS8,

    /// <summary>
    /// Key as a PEM-encoded SubjectPublicKeyInfo object
    /// </summary>
    PEM_SPKI
}

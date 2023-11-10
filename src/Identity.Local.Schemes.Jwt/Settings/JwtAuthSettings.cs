namespace Identity.Local.Schemes.Jwt.Settings;

public class JwtAuthSettings    
{
    public bool ValidateIssuer { get; set; }

    public string Issuer { get; set; } = default!;

    public bool ValidateAudience { get; set; }

    public string Audience { get; set; } = default!;

    public bool ValidateLifetime { get; set; }

    public int ExpirationTimeInMinutes { get; set; }

    public bool ValidateIssuerSigningKey { get; set; }

    public string SecretKey { get; set; } = default!;
}
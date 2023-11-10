namespace Identity.Local.Jwt.Models.Identity;

public class SignInDetails
{
    public string EmailAddress { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}
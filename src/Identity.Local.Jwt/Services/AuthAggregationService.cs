using System.Security.Authentication;
using Identity.Local.Jwt.Models.Entities;
using Identity.Local.Jwt.Models.Identity;

namespace Identity.Local.Jwt.Services;

public class AuthAggregationService : IAuthAggregationService
{
    private static readonly List<User> _users = new();
    private readonly ITokenGeneratorService _tokenGeneratorService;
    private readonly IPasswordHasherService _passwordHasherService;

    public AuthAggregationService(ITokenGeneratorService tokenGeneratorService, IPasswordHasherService passwordHasherService) =>
        (_tokenGeneratorService, _passwordHasherService) = (tokenGeneratorService, passwordHasherService);

    public ValueTask<bool> SignUpAsync(SignUpDetails signUpDetails, CancellationToken cancellationToken = default)
    {
        var foundUser = _users.Find(user => user.EmailAddress == signUpDetails.EmailAddress);

        if (foundUser is not null)
            throw new InvalidOperationException("User with this email address already exists.");

        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = signUpDetails.FirstName,
            LastName = signUpDetails.LastName,
            Age = signUpDetails.Age,
            EmailAddress = signUpDetails.EmailAddress,
            PasswordHash = _passwordHasherService.HashPassword(signUpDetails.Password),
        };

        _users.Add(user);

        return new ValueTask<bool>(true);
    }

    public ValueTask<string> SignInAsync(SignInDetails signInDetails, CancellationToken cancellationToken = default)
    {
        var foundUser = _users.Find(user => user.EmailAddress == signInDetails.EmailAddress);

        if (foundUser is null ||
            !_passwordHasherService.ValidatePassword(signInDetails.Password, foundUser.PasswordHash))
            throw new AuthenticationException("Login details are invalid, contact support.");

        var accessToken = _tokenGeneratorService.GetToken(foundUser);
        
        return new ValueTask<string>(accessToken);
    }
}
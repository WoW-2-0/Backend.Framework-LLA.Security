using Identity.Local.Schemes.Jwt.Models.Identity;
using Identity.Local.Schemes.Jwt.Services;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Local.Schemes.Jwt.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthAggregationService _authAggregationService;

    public AuthController(IAuthAggregationService authAggregationService)
    {
        _authAggregationService = authAggregationService;
    }

    [HttpPost("sign-up")]
    public async Task<IActionResult> SignUp([FromBody] SignUpDetails signUpDetails, CancellationToken cancellationToken)
    {
        var result = await _authAggregationService.SignUpAsync(signUpDetails, cancellationToken);
        return result ? Ok() : BadRequest();
    }

    [HttpPost("sign-in")]
    public async Task<IActionResult> SignIn([FromBody] SignInDetails signInDetails, CancellationToken cancellationToken)
    {
        var result = await _authAggregationService.SignInAsync(signInDetails, cancellationToken);
        return Ok(result);
    }
}
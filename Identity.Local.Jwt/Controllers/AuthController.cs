using Identity.Local.Jwt.Models.Identity;
using Identity.Local.Jwt.Services;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Local.Jwt.Controllers;

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
    public async Task<IActionResult> Register([FromBody] SignUpDetails signUpDetails, CancellationToken cancellationToken)
    {
        var result = await _authAggregationService.SignUpAsync(signUpDetails, cancellationToken);
        return result ? Ok() : BadRequest();
    }

    [HttpPost("sign-in")]
    public async Task<IActionResult> Login([FromBody] SignInDetails signInDetails, CancellationToken cancellationToken)
    {
        var result = await _authAggregationService.SignInAsync(signInDetails, cancellationToken);
        return Ok(result);
    }
}
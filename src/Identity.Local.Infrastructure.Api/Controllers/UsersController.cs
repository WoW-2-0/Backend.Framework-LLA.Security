using Identity.Local.Infrastructure.Application.Common.Identity.Services;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Local.Infrastructure.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{userId:guid}")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await _userService.GetByIdAsync(id);
        return result is not null ? Ok(result) : NotFound();
    }
}
using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Services;

namespace Rest.Controllers;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{platformId}")]
    public async Task<IActionResult> GetUserAsync([FromRoute] string platformId)
    {
        var user = await _userService.GetUserAsync(platformId);
        if (user is null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPut("save")]
    public async Task<IActionResult> SaveUserAsync([FromBody] User user)
    {
        await _userService.UpdateUserAsync(user);
        return Ok();
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateNewUserAsync([FromBody] string platformId)
    {
        var user = await _userService.CreateUserAsync(platformId);
        if (user is null)
        {
            return NotFound();
        }

        return Ok(user);
    }
}
using Microsoft.AspNetCore.Mvc;
using TheaterSystem.Application.Services.Authentication;
using TheaterSystem.Contracts;
using TheaterSystem.Contracts.Authentication;
using TheaterSystem.Infrastructure.Extensions;

namespace TheaterSystem.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{    
    [HttpPost("v1/register")]
    public IActionResult Register(
        RegisterRequest request,
        [FromServices] IAuthenticationService authenticationService)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultResponse<List<string>>(ModelState.GetErrors()));

        var result = authenticationService.Login(request.FirstName, request.LastName, request.Email, request.Password);
        var response = new AuthenticationResponse(
            result.Id,
            result.FirstName,
            result.LastName,
            result.Email,
            result.Token);
        
        return Ok(response);
    }

    [HttpPost("v1/login")]
    public IActionResult Login(
        LoginRequest request,
        [FromServices] IAuthenticationService authenticationService)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultResponse<List<string>>(ModelState.GetErrors()));
        
        var result = authenticationService.Register(request.Email, request.Password);
        var response = new AuthenticationResponse(
            result.Id,
            result.FirstName,
            result.LastName,
            result.Email,
            result.Token);
        
        return Ok(response);
    }
}
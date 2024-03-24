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
        [FromBody] RegisterRequest request,
        [FromServices] IAuthenticationService authenticationService)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultResponse<List<string>>(ModelState.GetErrors()));

        var result = authenticationService.Register(
            request.FirstName, 
            request.LastName, 
            request.Email, 
            request.Password,
            request.BirthDay);
        
        var response = new AuthenticationResponse(
            result.user.Id,
            result.user.FirstName,
            result.user.LastName,
            result.user.Email,
            result.user.BirthDay,
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
        
        var result = authenticationService.Login(request.Email, request.Password);
        var response = new AuthenticationResponse(
            result.user.Id,
            result.user.FirstName,
            result.user.LastName,
            result.user.Email,
            result.user.BirthDay,
            result.Token);
        
        return Ok(response);
    }
}
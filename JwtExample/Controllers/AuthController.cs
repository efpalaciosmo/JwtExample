using JwtExample.Entity;
using JwtExample.Entity.Dtos;
using JwtExample.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace JwtExample.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController: ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("Register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
    {
        ServiceResponse<int> response = await _authService.Register(
            new User
            {
                Username = request.Username,
                Email = request.Email,
                Name = request.Name,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Age = request.Age,
            }, request.Password
        );

        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }

    [HttpPost("Login")]
    public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDto request)
    {
        ServiceResponse<string> response = await _authService.Login(request.Username, request.Password);
        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);

    }
}
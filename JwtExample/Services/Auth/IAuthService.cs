using JwtExample.Entity;
using Microsoft.AspNetCore.Mvc;

namespace JwtExample.Services.Auth;

public interface IAuthService
{
    Task<ServiceResponse<int>> Register(User user, string password);
    Task<ServiceResponse<string>>Login(string username, string password);
    Task<bool> UserExists(string email);
}
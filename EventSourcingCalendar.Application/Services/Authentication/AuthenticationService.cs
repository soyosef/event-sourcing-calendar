using System;
namespace EventSourcingCalendar.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
  public AuthenticationResult Login(string FirstName, string LastName)
  {
    return new AuthenticationResult(Guid.NewGuid(), FirstName, LastName, "Email", "token");
  }

  public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
  {
    return new AuthenticationResult(Guid.NewGuid(), FirstName, LastName, Email, "token");
  }
}
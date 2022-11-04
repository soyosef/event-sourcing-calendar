namespace EventSourcingCalendar.Application.Services.Authentication;
public interface IAuthenticationService
{
  AuthenticationResult Login(string FirstName, string LastName);
  AuthenticationResult Register(string FirstName, string LastName, string Email, string Password);
}
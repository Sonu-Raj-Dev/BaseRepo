namespace Lead_Management.Core.Interfaces
{
    public interface IAuthenticationService
    {
        bool ValidateUser(string email, string password);
        Task<bool> ValidateUserAsync(string email, string password);
    }
}
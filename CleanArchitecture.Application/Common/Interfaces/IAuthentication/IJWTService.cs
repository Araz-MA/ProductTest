using CleanArchitecture.Domain.Entities.IdentityEntities;

namespace CleanArchitecture.Application.Common.Interfaces.IAuthentication
{
    public interface IJWTService
    {
        public string GenerateToken(User user);         
    }
}

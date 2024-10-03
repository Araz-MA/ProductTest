using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities.IdentityEntities
{
    public class Role : IdentityRole<int>
    {
       public string Description { get; set; }
    }

}

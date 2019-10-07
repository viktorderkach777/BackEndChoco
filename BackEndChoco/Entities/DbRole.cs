using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BackEndChoco.Entities
{
    public class DbRole : IdentityRole<int>
    {
        public ICollection<DbUserRole> UserRoles { get; set; }
    }
}
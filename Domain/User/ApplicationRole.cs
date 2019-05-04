using System;
using Microsoft.AspNetCore.Identity;

namespace DAL.EF
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

    }
}
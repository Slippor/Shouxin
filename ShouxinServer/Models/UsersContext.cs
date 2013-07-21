using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace ShouxinServer.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}

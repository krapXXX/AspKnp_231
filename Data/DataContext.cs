using Microsoft.EntityFrameworkCore;

namespace AspKnP231.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Entities.UserAccess> UserAccesses { get; set; }

        public DbSet<Entities.UserData> UsersData { get; set; }

        public DbSet<Entities.UserRole> UserRoles { get; set; }

    }
}

#nullable disable
using Microsoft.EntityFrameworkCore;

namespace ThanksCardAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ThanksCard> ThanksCards { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<Security> securities { get; set; }
    }
}

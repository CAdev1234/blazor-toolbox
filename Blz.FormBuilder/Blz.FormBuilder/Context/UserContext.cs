using Blz.FormBuilder.Data;
using Microsoft.EntityFrameworkCore;

namespace Blz.FormBuilder.Context
{
    public class UserContext : DbContext
    {
        public UserContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<LoginAudit> LoginAudits { get; set; }
        public DbSet<VerificationEmail> VerificationEmails { get; set; }
        public DbSet<AccountVerification> AccountVerifications { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=COM4\\SQLEXPRESS;Database=BlzFormBuilder;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

    }
}

using System.Data.Entity;
using EmailSender.Models.Domains;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EmailSender.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<EmailMessage> EmailMessages { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
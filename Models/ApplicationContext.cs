using Microsoft.EntityFrameworkCore;
using RolesApp.Models.Meeting;

namespace RolesApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<NameMeetingEvent> MeetingEvents { get; set; }
        public DbSet<MeetingInformation> MeetingInformations { get; set; }
        public DbSet<ListRegistrUsersOnEvent> listRegistrUsersOnEvents { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
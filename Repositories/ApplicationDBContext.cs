using Cafeine_DinDin_Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cafeine_DinDin_Backend.Repositories
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Image> Images{ get; set; }


    }
}

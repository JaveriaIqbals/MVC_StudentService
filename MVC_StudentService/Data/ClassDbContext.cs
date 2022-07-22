using Microsoft.EntityFrameworkCore;
using StudentMgtSys_MVC_CRUD_Service.Models;

namespace MVC_StudentService.Data
{
    public class ClassDbContext : DbContext
    {
        public ClassDbContext(DbContextOptions<ClassDbContext> options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Assignment> assignments { get; set; }

    }
}

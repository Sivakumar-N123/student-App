using Microsoft.EntityFrameworkCore;
using StudentApp.ViewModel;

namespace StudentApp.Data
{
    public class StudentAppDBContext: DbContext
    {
        public StudentAppDBContext(DbContextOptions<StudentAppDBContext>options): base(options)
        {
                
        }
        public DbSet<UserViewModel> UserTable { get; set; }
    }
}

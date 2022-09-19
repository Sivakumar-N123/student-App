using Microsoft.EntityFrameworkCore;
using StudentApp.ViewModel;

namespace StudentApp.Data
{
    public class studentAppDBContext: DbContext
    {
        public studentAppDBContext(DbContextOptions<studentAppDBContext>options): base(options)
        {
                
        }
        public DbSet<UserViewModel> UserTable { get; set; }
    }
}

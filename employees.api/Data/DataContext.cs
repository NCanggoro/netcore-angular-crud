using employees.api.Models;
using Microsoft.EntityFrameworkCore;

namespace employees.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> employees { get; set; }
    }
}
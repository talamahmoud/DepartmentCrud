using DepartmentCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ENG-TALA-ISMAIL;database=DepartmentCrud;trusted_connection=true;TrustServerCertificate=True;");
        }
    }
}

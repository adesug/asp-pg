using EmployeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeManagementSystem.Context
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Employe> Employes { get; set; }
    }
}

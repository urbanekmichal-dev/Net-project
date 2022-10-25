using Microsoft.EntityFrameworkCore;
using Net_project.Models.Domain;

namespace Net_project.Data
{
    public class MVCDemoDbContext : DbContext
    {
    }

    public DbSet<Employee> Employees { get;get }
}

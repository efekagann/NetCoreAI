using Microsoft.EntityFrameworkCore;

namespace NetCoreAI.Project1_ApiDemo.Context
{
    public class ApiContext:DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MyLocalDB; initial catalog=ApiAIDb; integrated security=true;trustservercertificate=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

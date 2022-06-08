using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ToDoApi.Models;

namespace ToDoApi
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration configuration;
        public DataContext(IConfiguration config)
        {
            configuration = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<TaskModel> Tasks { get; set; }

    }


    
}

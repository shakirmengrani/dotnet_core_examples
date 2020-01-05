using Microsoft.EntityFrameworkCore;

namespace api_example.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options){

        } 

        public DbSet<TodoItem> TodoItems {get; set;}
    }
}
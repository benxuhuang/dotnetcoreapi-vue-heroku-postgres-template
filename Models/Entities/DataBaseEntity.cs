using Microsoft.EntityFrameworkCore;
using dotnetcoreapi_vue_heroku_postgres_template.Models.Tables;  

namespace dotnetcoreapi_vue_heroku_postgres_template.Models.entities
{  
    public class DataBaseEntity : DbContext
    {
         public DataBaseEntity() { }

        public DataBaseEntity(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
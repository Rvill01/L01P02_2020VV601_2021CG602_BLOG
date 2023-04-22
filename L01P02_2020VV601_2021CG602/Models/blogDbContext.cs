using L01P02_2020VV601_2021CG602.Models;
using Microsoft.EntityFrameworkCore;

namespace L01P02_2020VV601_2021CG602.Controllers
{
    public class blogDbContext : DbContext
    {
        public blogDbContext(DbContextOptions options): base(options) 
        {

        }
        public DbSet<calificaciones> calificaciones { get;set; }
        public DbSet<comentarios> comentarios { get;set; }  
        public DbSet<publicaciones> publicaciones { get;set; }
        public DbSet<roles> roles { get;set; }
        public DbSet<usuarios> usuarios { get;set; }
    }
}

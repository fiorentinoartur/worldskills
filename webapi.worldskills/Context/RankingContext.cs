using Microsoft.EntityFrameworkCore;
using webapi.worldskills.Domains;

namespace webapi.worldskills.Context
{
    public class RankingContext : DbContext
    {
        public DbSet<Competidor> Competidor  {get;set;}
        public DbSet<Usuario> Usuario  {get;set;}
        public DbSet<TiposUsuario> TiposUsuario  {get;set;}
        public DbSet<Session> Session  {get;set;}
        public DbSet<Ranking> Ranking  {get;set;}
        public DbSet<Pais> Pais {get;set;}
        public DbSet<Medalha> Medalha  {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
     
            optionsBuilder.UseSqlServer("Server=ARTUR; Database=WorldSkills; User Id= sa; Pwd= Arcos@2020; TrustServerCertificate=true;");



            base.OnConfiguring(optionsBuilder);
        }
    }
}

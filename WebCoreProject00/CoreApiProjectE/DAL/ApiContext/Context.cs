using CoreApiProjectE.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiProjectE.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GAMZEMRYM_KAYA\\SQLEXPRESS;database=WebCoreProjectDB3;integrated security=true;");
        }
        public DbSet<Coiffeur> Coiffeurs{ get; set; }
    }
}

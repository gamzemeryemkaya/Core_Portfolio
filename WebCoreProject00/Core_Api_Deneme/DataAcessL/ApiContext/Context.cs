using Core_Api_Deneme.DataAcessL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Api_Deneme.DataAcessL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GAMZEMRYM_KAYA\\SQLEXPRESS;database=WebCoreProjectDB2;integrated security=true;");
        }
        public DbSet<MakuCiftlik> MakuCiftliks { get; set; }
    }
}

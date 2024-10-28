using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProyectodeferrerMaster.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeferrerMaster
{
    internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {

        public ApplicationDbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Data LAPTOP-GIGABYTE;Initial Catalog=TiendaOnline1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"); 

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_HelloWorld.Models;

namespace MVC_HelloWorld
{
    public class ECommerceDbContext:DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options):base(options)
        {

        }

        //Add Models
        public DbSet<Registration> RegistrationTable { get; set; }
        public DbSet<Login> LoginTable { get; set; }
    }
}

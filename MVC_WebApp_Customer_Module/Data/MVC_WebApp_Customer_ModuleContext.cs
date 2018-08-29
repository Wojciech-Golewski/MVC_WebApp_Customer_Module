using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_WebApp_Customer_Module.Models
{
    public class MVC_WebApp_Customer_ModuleContext : DbContext
    {
        public MVC_WebApp_Customer_ModuleContext (DbContextOptions<MVC_WebApp_Customer_ModuleContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_WebApp_Customer_Module.Models.Customer> Customer { get; set; }
    }
}

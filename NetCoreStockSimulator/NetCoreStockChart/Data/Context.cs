using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreStockChart.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCoreStockChart.Models;

using NetCoreStockChart;
using Microsoft.Extensions.Options;


namespace NetCoreStockChart.Data
{
    public class Context : IdentityDbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<order> orders { get; set; }
    }
}

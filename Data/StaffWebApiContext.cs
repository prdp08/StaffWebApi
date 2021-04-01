using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaffWebApi.Models;

namespace StaffWebApi.Data
{
    public class StaffWebApiContext : DbContext
    {
        public StaffWebApiContext (DbContextOptions<StaffWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<StaffWebApi.Models.StaffName> StaffName { get; set; }
    }
}

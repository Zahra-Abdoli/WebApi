using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Lab7.Entities
{
  
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> option) : base(option)
            {

            }

           
            public DbSet<User> Users { get; set; }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using student.Models;

namespace student.Data
{
    public class studentContext : DbContext
    {
        public studentContext (DbContextOptions<studentContext> options)
            : base(options)
        {
        }

        public DbSet<student.Models.Student> Student { get; set; }
    }
}

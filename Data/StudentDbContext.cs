using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStudentDatabaseAPI.Models;

namespace WebStudentDatabaseAPI.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext (DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebStudentDatabaseAPI.Models.Student> Student { get; set; } = default!;
    }
}

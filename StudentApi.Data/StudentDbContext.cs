using Microsoft.EntityFrameworkCore;
using StudentApi.Entities;
using System;

namespace StudentApi.Data
{
    public class StudentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=SEVGI-PC\\SQLEXPRESS;Database=StudentDb;uid=sa;pwd=1234;");
        }
        public DbSet<Student> Students { get; set; }

    }
}

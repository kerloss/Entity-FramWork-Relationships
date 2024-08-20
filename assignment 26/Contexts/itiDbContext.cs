using assignment_26.Configurations;
using assignment_26.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_26.Contexts
{
    internal class itiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = KERLOSS ; DataBase = ITIDbContext2 ; Trusted_Connection = true ; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API Configuration Realationships

            //getdate for table course
            //modelBuilder.Entity<Course>(E => { E.Property(C => C.Duration).HasComputedColumnSql("GETDATE()"); });

            //modelBuilder.Entity<Course_Inst>().HasKey(c => c.Inst_Id);
            //modelBuilder.Entity<Stud_Course>().HasKey(s => s.Stud_Id);

            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new Student_CourseConfiguration());

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}

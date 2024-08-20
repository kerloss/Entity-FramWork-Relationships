using assignment_26.Contexts;
using assignment_26.Entitys;
using Microsoft.EntityFrameworkCore;

namespace assignment_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            itiDbContext itiDbContext = new itiDbContext(); //open connection with database

            Course course = new Course()
            {
                Name = "ahmed",
                Duration = DateTime.Now,
                Description = "class course",
            };
            Course course2 = new Course()
            {
                Name = "wale",
                Duration = DateTime.Now,
                Description = "class course",
            };
            Department department = new Department()
            {
                Name = "kerloss",
                HiringDate = DateTime.Now,
                
            };
            Department department1 = new Department()
            {
                Name = "jooo",
                HiringDate = DateTime.Now,
            };
            Instructor instructor = new Instructor()
            {
                Name = "omar",
                Address = "haram-giza",
                Bounce = 3000,
                Hour_Rate = 2000,
                Salary = 5000,
            };
            Instructor instructor1 = new Instructor()
            {
                Name = "hassan",
                Address = "haram-giza",
                Bounce = 3000,
                Hour_Rate = 2000,
                Salary = 5000,
            };
            Student student = new Student()
            {
                Address = "giza",
                Age = 30,
                FName = "ahmed",
                LName = "mohamed",
            };
            Student student1 = new Student()
            {
                Address = "october",
                Age = 20,
                FName = "youssif",
                LName = "wazir",
            };

            try
            {
                #region Add
                //itiDbContext.Add(course);
                //itiDbContext.Add(course2);
                //itiDbContext.SaveChanges(); 

                //itiDbContext.Departments.Add(department);
                //itiDbContext.Departments.Add(department1);
                //itiDbContext.SaveChanges();

                //itiDbContext.Instructors.Add(instructor);
                //itiDbContext.Instructors.Add(instructor1);
                //itiDbContext.SaveChanges();
                #endregion

                #region select
                //var cours = (from c in itiDbContext.Courses
                //             where c.Id == 1
                //             select c).AsNoTracking().FirstOrDefault();
                //Console.WriteLine(cours?.Name ?? "N/A");

                //var inst = (from i in itiDbContext.Instructors
                //            where i.Id == 1
                //            select i).AsNoTracking().FirstOrDefault();
                //Console.WriteLine(inst?.Name ?? "N/A");
                #endregion

                #region update
                //var changeName = (from c in itiDbContext.Courses
                //                  where c.Id == 3
                //                  select c).FirstOrDefault();
                //changeName.Name = "yassir";
                //itiDbContext.SaveChanges();

                //var changeTopId = (from c in itiDbContext.Courses
                //                   where c.Id == 1
                //                   select c).FirstOrDefault();
                //changeTopId.Top_Id = 3;
                //itiDbContext.SaveChanges();
                #endregion

                #region Delete
                //var removes = (from i in itiDbContext.Instructors
                //               where i.Id == 1
                //               select i).FirstOrDefault();
                //itiDbContext.Remove(removes);
                //itiDbContext.SaveChanges();

                //var remove2 = (from c in itiDbContext.Courses
                //                  where c.Id == 2
                //                  select c).FirstOrDefault();
                //itiDbContext.Remove(remove2);
                //itiDbContext.SaveChanges();
                #endregion
            }
            finally
            {
                    itiDbContext.Dispose(); //to close connection
            }
        }
    }
}

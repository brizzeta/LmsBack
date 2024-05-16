using Microsoft.EntityFrameworkCore;

namespace LmsBack.Model
{
    public class LmsDbContext : DbContext
    {
        #region Свойства

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DayOfWeek> DayOfWeeks { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Attendence> Attendences { get; set; }
        public DbSet<HomeworkMark> HomeworkMarks { get; set; }
        public DbSet<HomeworkStudent> HomeworkStudents { get; set; }
        public DbSet<HomeworkTeacher> HomeworkTeachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonMark> LessonMarks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TimeOfLesson> TimeOfLessons { get; set; }

        #endregion

        public LmsDbContext(DbContextOptions<LmsDbContext> options) : base(options) 
        {
            if (Database.EnsureCreated())
            {
                var roles = new List<Role>()
                {
                    new Role { Name="Director" },
                    new Role { Name="Admin" },
                };
                Roles?.AddRange(roles);

                var dayOfWeeks = new List<DayOfWeek>()
                {
                    new DayOfWeek {Name="Monday"},
                    new DayOfWeek {Name="Tuesday"},
                    new DayOfWeek {Name="Wednesday"},
                    new DayOfWeek {Name="Thursday"},
                    new DayOfWeek {Name="Friday"},
                    new DayOfWeek {Name="Saturday"},
                    new DayOfWeek {Name="Sunday"},
                };
            }
        }
    }
}

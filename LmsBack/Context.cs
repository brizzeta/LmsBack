using LmsBack.Model;
using Microsoft.EntityFrameworkCore;

namespace LmsBack {
    public class Context : DbContext {
        #region Дбсеты
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Model.DayOfWeek> DayOfWeeks { get; set; }
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
        public Context(DbContextOptions<Context> options) : base(options) {
            if (Database.EnsureCreated()) {
                Roles!.AddRange(new List<Role>() {
                    new Role { Name="Director" },
                    new Role { Name="Admin" }
                });
                DayOfWeeks!.AddRange(new List<Model.DayOfWeek>() {
                    new Model.DayOfWeek { Name = "Monday" },
                    new Model.DayOfWeek { Name = "Tuesday" },
                    new Model.DayOfWeek { Name = "Wednesday" },
                    new Model.DayOfWeek { Name = "Thursday" },
                    new Model.DayOfWeek { Name = "Friday" },
                    new Model.DayOfWeek { Name = "Saturday" },
                    new Model.DayOfWeek { Name = "Sunday" }
                });
                SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies();
    }
}
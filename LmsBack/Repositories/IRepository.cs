using LmsBack.Model;
using Microsoft.EntityFrameworkCore;

namespace LmsBack.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T item);
        void Update(T item);
        Task Delete(int id);
        Task Save();
    }

    public class AccountRepository : IRepository<Account>
    {
        private readonly LmsDbContext db;
        public AccountRepository(LmsDbContext context) => db = context;
        public async Task<IList<Account>> GetAll() => await db.Accounts.ToListAsync();
        public async Task<Account> GetById(int id) => await db.Accounts.FindAsync(id);
        public async Task Insert(Account account) => await db.Accounts.AddAsync(account);
        public void Update(Account account) => db.Entry(account).State = EntityState.Modified;
        public async Task Delete(int id) => db.Accounts.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class AdminRepository : IRepository<Admin>
    {
        private readonly LmsDbContext db;
        public AdminRepository(LmsDbContext context) => db = context;
        public async Task<IList<Admin>> GetAll() => await db.Admins.ToListAsync();
        public async Task<Admin> GetById(int id) => await db.Admins.FindAsync(id);
        public async Task Insert(Admin admin) => await db.Admins.AddAsync(admin);
        public void Update(Admin admin) => db.Entry(admin).State = EntityState.Modified;
        public async Task Delete(int id) => db.Admins.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class AttendenceRepository : IRepository<Attendence>
    {
        private readonly LmsDbContext db;
        public AttendenceRepository(LmsDbContext context) => db = context;
        public async Task<IList<Attendence>> GetAll() => await db.Attendences.ToListAsync();
        public async Task<Attendence> GetById(int id) => await db.Attendences.FindAsync(id);
        public async Task Insert(Attendence attendence) => await db.Attendences.AddAsync(attendence);
        public void Update(Attendence attendence) => db.Entry(attendence).State = EntityState.Modified;
        public async Task Delete(int id) => db.Attendences.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class CourseRepository : IRepository<Course>
    {
        private readonly LmsDbContext db;
        public CourseRepository(LmsDbContext context) => db = context;
        public async Task<IList<Course>> GetAll() => await db.Courses.ToListAsync();
        public async Task<Course> GetById(int id) => await db.Courses.FindAsync(id);
        public async Task Insert(Course course) => await db.Courses.AddAsync(course);
        public void Update(Course course) => db.Entry(course).State = EntityState.Modified;
        public async Task Delete(int id) => db.Courses.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class GroupRepository : IRepository<Group>
    {
        private readonly LmsDbContext db;
        public GroupRepository(LmsDbContext context) => db = context;
        public async Task<IList<Group>> GetAll() => await db.Groups.ToListAsync();
        public async Task<Group> GetById(int id) => await db.Groups.FindAsync(id);
        public async Task Insert(Group group) => await db.Groups.AddAsync(group);
        public void Update(Group group) => db.Entry(group).State = EntityState.Modified;
        public async Task Delete(int id) => db.Groups.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class HomeworkMarkRepository : IRepository<HomeworkMark>
    {
        private readonly LmsDbContext db;
        public HomeworkMarkRepository(LmsDbContext context) => db = context;
        public async Task<IList<HomeworkMark>> GetAll() => await db.HomeworkMarks.ToListAsync();
        public async Task<HomeworkMark> GetById(int id) => await db.HomeworkMarks.FindAsync(id);
        public async Task Insert(HomeworkMark homeworkMark) => await db.HomeworkMarks.AddAsync(homeworkMark);
        public void Update(HomeworkMark homeworkMark) => db.Entry(homeworkMark).State = EntityState.Modified;
        public async Task Delete(int id) => db.HomeworkMarks.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class HomeworkStudentRepository : IRepository<HomeworkStudent>
    {
        private readonly LmsDbContext db;
        public HomeworkStudentRepository(LmsDbContext context) => db = context;
        public async Task<IList<HomeworkStudent>> GetAll() => await db.HomeworkStudents.ToListAsync();
        public async Task<HomeworkStudent> GetById(int id) => await db.HomeworkStudents.FindAsync(id);
        public async Task Insert(HomeworkStudent homeworkStudent) => await db.HomeworkStudents.AddAsync(homeworkStudent);
        public void Update(HomeworkStudent homeworkStudent) => db.Entry(homeworkStudent).State = EntityState.Modified;
        public async Task Delete(int id) => db.HomeworkStudents.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class HomeworkTeacherRepository : IRepository<HomeworkTeacher>
    {
        private readonly LmsDbContext db;
        public HomeworkTeacherRepository(LmsDbContext context) => db = context;
        public async Task<IList<HomeworkTeacher>> GetAll() => await db.HomeworkTeachers.ToListAsync();
        public async Task<HomeworkTeacher> GetById(int id) => await db.HomeworkTeachers.FindAsync(id);
        public async Task Insert(HomeworkTeacher homeworkTeacher) => await db.HomeworkTeachers.AddAsync(homeworkTeacher);
        public void Update(HomeworkTeacher homeworkTeacher) => db.Entry(homeworkTeacher).State = EntityState.Modified;
        public async Task Delete(int id) => db.HomeworkTeachers.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class LessonRepository : IRepository<Lesson>
    {
        private readonly LmsDbContext db;
        public LessonRepository(LmsDbContext context) => db = context;
        public async Task<IList<Lesson>> GetAll() => await db.Lessons.ToListAsync();
        public async Task<Lesson> GetById(int id) => await db.Lessons.FindAsync(id);
        public async Task Insert(Lesson lesson) => await db.Lessons.AddAsync(lesson);
        public void Update(Lesson lesson) => db.Entry(lesson).State = EntityState.Modified;
        public async Task Delete(int id) => db.Lessons.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class LessonMarkRepository : IRepository<LessonMark>
    {
        private readonly LmsDbContext db;
        public LessonMarkRepository(LmsDbContext context) => db = context;
        public async Task<IList<LessonMark>> GetAll() => await db.LessonMarks.ToListAsync();
        public async Task<LessonMark> GetById(int id) => await db.LessonMarks.FindAsync(id);
        public async Task Insert(LessonMark lessonMark) => await db.LessonMarks.AddAsync(lessonMark);
        public void Update(LessonMark lessonMark) => db.Entry(lessonMark).State = EntityState.Modified;
        public async Task Delete(int id) => db.LessonMarks.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class ManagerRepository : IRepository<Manager>
    {
        private readonly LmsDbContext db;
        public ManagerRepository(LmsDbContext context) => db = context;
        public async Task<IList<Manager>> GetAll() => await db.Managers.ToListAsync();
        public async Task<Manager> GetById(int id) => await db.Managers.FindAsync(id);
        public async Task Insert(Manager manager) => await db.Managers.AddAsync(manager);
        public void Update(Manager manager) => db.Entry(manager).State = EntityState.Modified;
        public async Task Delete(int id) => db.Managers.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class ParentRepository : IRepository<Parent>
    {
        private readonly LmsDbContext db;
        public ParentRepository(LmsDbContext context) => db = context;
        public async Task<IList<Parent>> GetAll() => await db.Parents.ToListAsync();
        public async Task<Parent> GetById(int id) => await db.Parents.FindAsync(id);
        public async Task Insert(Parent parent) => await db.Parents.AddAsync(parent);
        public void Update(Parent parent) => db.Entry(parent).State = EntityState.Modified;
        public async Task Delete(int id) => db.Parents.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class ScheduleRepository : IRepository<Schedule>
    {
        private readonly LmsDbContext db;
        public ScheduleRepository(LmsDbContext context) => db = context;
        public async Task<IList<Schedule>> GetAll() => await db.Schedules.ToListAsync();
        public async Task<Schedule> GetById(int id) => await db.Schedules.FindAsync(id);
        public async Task Insert(Schedule schedule) => await db.Schedules.AddAsync(schedule);
        public void Update(Schedule schedule) => db.Entry(schedule).State = EntityState.Modified;
        public async Task Delete(int id) => db.Schedules.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class StudentRepository : IRepository<Student>
    {
        private readonly LmsDbContext db;
        public StudentRepository(LmsDbContext context) => db = context;
        public async Task<IList<Student>> GetAll() => await db.Students.ToListAsync();
        public async Task<Student> GetById(int id) => await db.Students.FindAsync(id);
        public async Task Insert(Student student) => await db.Students.AddAsync(student);
        public void Update(Student student) => db.Entry(student).State = EntityState.Modified;
        public async Task Delete(int id) => db.Students.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly LmsDbContext db;
        public TeacherRepository(LmsDbContext context) => db = context;
        public async Task<IList<Teacher>> GetAll() => await db.Teachers.ToListAsync();
        public async Task<Teacher> GetById(int id) => await db.Teachers.FindAsync(id);
        public async Task Insert(Teacher teachers) => await db.Teachers.AddAsync(teachers);
        public void Update(Teacher teachers) => db.Entry(teachers).State = EntityState.Modified;
        public async Task Delete(int id) => db.Teachers.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

    public class TimeOfLessonRepository : IRepository<TimeOfLesson>
    {
        private readonly LmsDbContext db;
        public TimeOfLessonRepository(LmsDbContext context) => db = context;
        public async Task<IList<TimeOfLesson>> GetAll() => await db.TimeOfLessons.ToListAsync();
        public async Task<TimeOfLesson> GetById(int id) => await db.TimeOfLessons.FindAsync(id);
        public async Task Insert(TimeOfLesson timeOfLesson) => await db.TimeOfLessons.AddAsync(timeOfLesson);
        public void Update(TimeOfLesson timeOfLesson) => db.Entry(timeOfLesson).State = EntityState.Modified;
        public async Task Delete(int id) => db.TimeOfLessons.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }

}

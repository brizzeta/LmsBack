using Microsoft.EntityFrameworkCore;
using LmsBack.Model;
using LmsBack.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Получаем строку подключения из файла конфигурации
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<LmsDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped<IRepository<Account>, AccountRepository>();
builder.Services.AddScoped<IRepository<Admin>, AdminRepository>();
builder.Services.AddScoped<IRepository<Attendence>, AttendenceRepository>();
builder.Services.AddScoped<IRepository<Course>, CourseRepository>();
builder.Services.AddScoped<IRepository<Group>, GroupRepository>();
builder.Services.AddScoped<IRepository<HomeworkMark>, HomeworkMarkRepository>();
builder.Services.AddScoped<IRepository<HomeworkStudent>, HomeworkStudentRepository>();
builder.Services.AddScoped<IRepository<HomeworkTeacher>, HomeworkTeacherRepository>();
builder.Services.AddScoped<IRepository<Lesson>, LessonRepository>();
builder.Services.AddScoped<IRepository<LessonMark>, LessonMarkRepository>();
builder.Services.AddScoped<IRepository<Manager>, ManagerRepository>();
builder.Services.AddScoped<IRepository<Parent>, ParentRepository>();
builder.Services.AddScoped<IRepository<Schedule>, ScheduleRepository>();
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
builder.Services.AddScoped<IRepository<Teacher>, TeacherRepository>();
builder.Services.AddScoped<IRepository<TimeOfLesson>, TimeOfLessonRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

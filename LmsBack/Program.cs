using Microsoft.EntityFrameworkCore;
using LmsBack.Model;
using LmsBack.Repositories;
using LmsBack;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

// Получаем строку подключения из файла и добавляем ее в контекст в качестве сервиса в приложение
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connection));

// Подключаем сервисы репозиториев для работы с контекстом бд
builder.Services.AddScoped<IRepository<Account>, Repository<Account>>();
builder.Services.AddScoped<IRepository<Admin>, Repository<Admin>>();
builder.Services.AddScoped<IRepository<Attendence>, Repository<Attendence>>();
builder.Services.AddScoped<IRepository<Course>, Repository<Course>>();
builder.Services.AddScoped<IRepository<Group>, Repository<Group>>();
builder.Services.AddScoped<IRepository<HomeworkMark>, Repository<HomeworkMark>>();
builder.Services.AddScoped<IRepository<HomeworkStudent>, Repository<HomeworkStudent>>();
builder.Services.AddScoped<IRepository<HomeworkTeacher>, Repository<HomeworkTeacher>>();
builder.Services.AddScoped<IRepository<Lesson>, Repository<Lesson>>();
builder.Services.AddScoped<IRepository<LessonMark>, Repository<LessonMark>>();
builder.Services.AddScoped<IRepository<Manager>, Repository<Manager>>();
builder.Services.AddScoped<IRepository<Parent>, Repository<Parent>>();
builder.Services.AddScoped<IRepository<Schedule>, Repository<Schedule>>();
builder.Services.AddScoped<IRepository<Student>, Repository<Student>>();
builder.Services.AddScoped<IRepository<Teacher>, Repository<Teacher>>();
builder.Services.AddScoped<IRepository<TimeOfLesson>, Repository<TimeOfLesson>>();
// Подключаем сервис криптографии для шифрования пароля
builder.Services.AddScoped<ICryptography, Cryptography>();

var app = builder.Build();

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());

if (app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
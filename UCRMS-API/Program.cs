using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.EntityFrameworkCore;
using UCRMS_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddPolicy(name: "UCRMS_Origins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<ISemesterService, SemesterService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IDesignationService, DesignationService>();
builder.Services.AddScoped<ICourseAssignmentService, CourseAssignmentService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ICourseStaticsVMService, CourseStaticsVMService>();
builder.Services.AddScoped<IDayService, DayService>();
builder.Services.AddScoped<IRoomNoService, RoomNoService>();
builder.Services.AddScoped<IAllocateClassroomService, AllocateClassroomService>();
builder.Services.AddScoped<ICourseEnrollmentService, CourseEnrollmentService>();
builder.Services.AddScoped<IGradeLetterService, GradeLetterService>();
builder.Services.AddScoped<ISaveResultService, SaveResultService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("UCRMS_Origins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

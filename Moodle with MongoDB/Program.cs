
using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;
using Moodle_with_MongoDB.Service;

namespace Moodle_with_MongoDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                                      policy =>
                                      {
                                          policy.AllowAnyOrigin()
                                                .AllowAnyHeader()
                                                .AllowAnyMethod();
                                      });
            });


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.Configure<MongoDBSettings>(
                builder.Configuration.GetSection("MongoDBSettings"));
            builder.Services.AddSingleton<IMongoDatabase>(option =>
            {
                var mongodbsettings = builder.Configuration.GetSection("MongoDBSettings").Get<MongoDBSettings>();
                var client = new MongoClient(mongodbsettings.ConnectionString);
                return client.GetDatabase(mongodbsettings.DatabaseName);
            });

            builder.Services.AddSingleton<ITeacherRepository, TeacherRepository>();
            builder.Services.AddSingleton<ICourseRepsitory, CourseRepository>();
            builder.Services.AddSingleton<IFileRepository, FileRepository>();
            builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
            builder.Services.AddSingleton<IUserRepository, UserRepository>();
            builder.Services.AddSingleton<ICourseService, CourseService>();
            builder.Services.AddSingleton<ITeacherService, TeacherService>();
            builder.Services.AddSingleton<IStudentService, StudentService>();
            builder.Services.AddSingleton<IUserService, UserService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(MyAllowSpecificOrigins);

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}


using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using Moodle_with_MongoDB.Repository;

namespace Moodle_with_MongoDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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

            builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
            builder.Services.AddSingleton<ICourseRepsitory,CourseRepository>(); 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

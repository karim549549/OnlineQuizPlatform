using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineQuizPlatform.Database;
using OnlineQuizPlatform.Helpers;



namespace OnlineQuizPlatform
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            string databasePath = "D:/ParallelProcessing/Project/OnlineQuizPlatform/OnlineQuizPlatform/Database/Sqlite/MyDatabase.db";
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite("Data Source=MyDatabase.db"));



            services.AddScoped<UserServices>();
            services.AddTransient<Form1>();

            var serviceProvider = services.BuildServiceProvider();
            //using (var scope = serviceProvider.CreateScope())
            //{
            //    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //    DataSeeder.SeedQuestions(dbContext);
            //}
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}

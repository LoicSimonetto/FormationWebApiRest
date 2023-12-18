using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder OptionBuilder = new DbContextOptionsBuilder();
            OptionBuilder.UseSqlServer(connectionString);
            
            using (DefaultContext context = new DefaultContext(OptionBuilder.Options))
            {
                var query = from droide in context.Droides
                            select droide;

                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }
            }
            
        }
    }
}

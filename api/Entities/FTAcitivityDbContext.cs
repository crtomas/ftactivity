using Microsoft.EntityFrameworkCore;

namespace FTActivity.Entities
{
    public class FTActivityDbContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }

        public FTActivityDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            // docker run --name efmysql -p 3306:3306 -e MYSQL_ROOT_PASSWORD=admin -d mysql:latest
            // docker run --name myadmin -d -e PMA_HOST=192.168.99.100 -p 8080:80 phpmyadmin/phpmyadmin
            //optionsBuilder.UseMySql("server=192.168.99.100;database=FTActivity;user=root;password=admin");
        //}
    }

}
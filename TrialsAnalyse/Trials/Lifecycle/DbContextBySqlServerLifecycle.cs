using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Trials.Entitys;

namespace Trials.Lifecycle
{
    /// <summary>
    /// 用于 <see cref="SqlServerLifecycleTest"/> 测试的 <see cref="DbContext"/>。
    /// </summary>
    public class DbContextBySqlServerLifecycle : DbContext
    {
        public DbSet<SimpleEntity> Simples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration conf = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(conf.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SimpleEntity>()
                        .ToTable("Simple");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using FDMPrintCostEstimator.Model;

namespace FDMPrintCostEstimator.Data.Contexts
{
    public class ProjectContext : DbContext
    {
        public DbSet<Filaments> Filaments { get; set; }
        public DbSet<Printers> Printers { get; set; }
        public DbSet<UserData> UserData { get; set; }

        public string DbPath { get; }

        public ProjectContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "FDMPrintCostEstimator.db3");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
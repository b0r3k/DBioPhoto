using Microsoft.EntityFrameworkCore;
using DBioPhoto.Domain.Models;
using System;
using System.IO;

namespace DBioPhoto.DataAccess.Data
{
    public class DBioPhotoContext : DbContext
    {
        private readonly string _dbPath;

        public DBioPhotoContext(string dbPath, bool notFirst=true)
        {
            _dbPath = dbPath;
        }

        // Configure the db connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                             "AttachDbFilename={0};" +
                                             "Integrated Security=True;" +
                                             "Initial Catalog={1}", 
                                             _dbPath, Path.GetFileNameWithoutExtension(_dbPath));
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Set tables
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Organism> Organisms { get; set; }
    }
}

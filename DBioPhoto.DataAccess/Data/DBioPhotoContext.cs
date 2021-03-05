using Microsoft.EntityFrameworkCore;
using DBioPhoto.Domain.Models;
using System;
using System.IO;

namespace DBioPhoto.DataAccess.Data
{
    public class DBioPhotoContext : DbContext
    {
        private readonly string _dbPath;

        public DBioPhotoContext(string dbPath)
        {
            _dbPath = dbPath;
        }

        // Configure the db connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                             AttachDbFilename="+_dbPath+"; " +
                                             "Integrated Security=True;" +
                                             "Initial Catalog=DBioPhotoDB");
        }

        // Set tables
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Organism> Organisms { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using DBioPhoto.Domain.Models;
using System;
using System.IO;

namespace DBioPhoto.DataAccess.Data
{
    public class DBioPhotoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbPath = documentsPath + "\\DBioPhotoDB.mdf";
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                             AttachDbFilename="+dbPath+"; " +
                                             "Integrated Security=True;" +
                                             "Initial Catalog=DBioPhotoDB");
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Organism> Organisms { get; set; }
        /*public DbSet<Plant> Plants { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Fungus> Fungi { get; set; }
        public DbSet<Micro> Micros { get; set; }*/
        /*public DbSet<PersonOnPhoto> PersonOnPhotos { get; set; }
        public DbSet<PlantOnPhoto> PlantOnPhotos { get; set; }
        public DbSet<AnimalOnPhoto> AnimalOnPhotos { get; set; }
        public DbSet<FungusOnPhoto> FungusOnPhotos { get; set; }
        public DbSet<MicroOnPhoto> MicroOnPhotos { get; set; }*/
    }
}

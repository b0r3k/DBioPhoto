﻿using Microsoft.EntityFrameworkCore;
using DBioPhoto.Domain.Models;

namespace DBioPhoto.DataAccess.Data
{
    class DBioPhotoContext : DbContext
    {
        public DBioPhotoContext(DbContextOptions<DBioPhotoContext> options)
            : base(options)
        {
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Fungus> Fungi { get; set; }
        public DbSet<Micro> Micros { get; set; }
        public DbSet<PersonOnPhoto> PersonOnPhotos { get; set; }
        public DbSet<PlantOnPhoto> PlantOnPhotos { get; set; }
        public DbSet<AnimalOnPhoto> AnimalOnPhotos { get; set; }
        public DbSet<FungusOnPhoto> FungusOnPhotos { get; set; }
        public DbSet<MicroOnPhoto> MicroOnPhotos { get; set; }
    }
}

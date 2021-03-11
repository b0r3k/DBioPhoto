﻿using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using System.Linq;

namespace DBioPhoto.DataAccess.Services.Adding
{
    public class AddPhoto
    {
        public static string TryAddPhoto(DBioPhotoContext dbContext, Photo tryPhoto)
        {
            // No photo selected
            if (tryPhoto.FileName == null || tryPhoto.FileName == "" || tryPhoto.FilePath == null || tryPhoto.FilePath == "")
                return "Zvolte fotku";

            // Photo already in db, update
            else if (dbContext.Photos.Any(p => p.FilePath == tryPhoto.FilePath))
            {
                Photo existingPhoto = dbContext.Photos.FirstOrDefault(p => p.FilePath == tryPhoto.FilePath);
                existingPhoto.Category = tryPhoto.Category;
                existingPhoto.Comment = tryPhoto.Comment;
                existingPhoto.Location = tryPhoto.Location;
                return "Úspěšně aktualizováno!";
            }

            // Add to db
            else
            {
                dbContext.Photos.Add(tryPhoto);
                dbContext.SaveChanges();
                return "Úspěšně přidáno!";
            }
        }
    }
}
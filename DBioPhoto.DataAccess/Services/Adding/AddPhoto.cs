using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
                dbContext.SaveChanges();
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


        public static (List<Organism>, List<Person>) GetPhotoContent(DBioPhotoContext dbContext, string fileRelativePath)
        {
            var photoQuery = dbContext.Photos.Where(p => p.FilePath == fileRelativePath);
            List<Organism> organismsOnPhoto = photoQuery.Select(p => p.Organisms).ToList().FirstOrDefault();
            List<Person> peopleOnPhoto = photoQuery.Select(p => p.People).ToList().FirstOrDefault();
            return (organismsOnPhoto, peopleOnPhoto);
        }


        public static void RemoveOrganismFromPhoto(DBioPhotoContext dbContext, string fileRelativePath, int indexInList)
        {
            Photo photo = dbContext.Photos.Where(p => p.FilePath == fileRelativePath).Include(p => p.Organisms).FirstOrDefault();
            if (indexInList < photo.Organisms.Count)
                photo.Organisms.RemoveAt(indexInList);
            dbContext.SaveChanges();
        }
        public static void RemovePersonFromPhoto(DBioPhotoContext dbContext, string fileRelativePath, int indexInList)
        {
            Photo photo = dbContext.Photos.Where(p => p.FilePath == fileRelativePath).Include(p => p.People).FirstOrDefault();
            if (indexInList < photo.People.Count)
                photo.People.RemoveAt(indexInList);
            dbContext.SaveChanges();
        }


        public static bool TryAddOrganismToPhoto(DBioPhotoContext dbContext, string photoRelativePath, string organismFirstName, string organismSecondName)
        {
            Photo photo = dbContext.Photos.Where(p => p.FilePath == photoRelativePath).Include(p => p.Organisms).FirstOrDefault();
            Organism organism = dbContext.Organisms.Where(o => o.FirstName == organismFirstName && o.SecondName == organismSecondName).FirstOrDefault();
            // If the organism didn't have second name, then the SecondName is LatFirstName in fact
            if (organism == null)
                organism = dbContext.Organisms.Where(o => o.FirstName == organismFirstName && o.LatFirstName == organismSecondName).FirstOrDefault();
            if (photo == null || organism == null)
            {
                return false;
            }
            else if (photo.Organisms.Contains(organism))
            {
                return false;
            }
            else
            {
                photo.Organisms.Add(organism);
                dbContext.SaveChanges();
                return true;
            }
        }
        public static bool TryAddPersonToPhoto(DBioPhotoContext dbContext, string photoRelativePath, string personName, string personSurname)
        {
            Photo photo = dbContext.Photos.Where(p => p.FilePath == photoRelativePath).Include(p => p.People).FirstOrDefault();
            Person person = dbContext.People.Where(p => p.Name == personName && p.Surname == personSurname).FirstOrDefault();
            if (photo == null || person == null)
            {
                return false;
            }
            else if (photo.People.Contains(person))
            {
                return false;
            }
            else
            {
                photo.People.Add(person);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}

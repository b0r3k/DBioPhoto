﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;

namespace DBioPhoto.DataAccess.Services.Filtering
{
    public class SearchPhotos
    {
        public static string[] SearchPhoto(DBioPhotoContext dbContext, int basedOn, string[] names, ValueTuple<Category, DateTime, DateTime, string, string> photoInfo)
        {
            string[] photosFound;
            IQueryable<Photo> photosQuery = dbContext.Photos.AsQueryable();
            switch (basedOn)
            {
                case 0:
                    break;
                case 1:
                    if (names[1] != "")
                        photosQuery = dbContext.Organisms
                            .Where(o => o.FirstName == names[0] && o.SecondName == names[1])
                            .SelectMany(o => o.Photos);
                    else
                        photosQuery = dbContext.Organisms.Where(o => o.FirstName == names[0]).SelectMany(o => o.Photos);
                    break;
                case 2:
                    if (names[1] != "")
                        photosQuery = dbContext.Organisms.Where(o => o.LatFirstName == names[0] && o.LatSecondName == names[1]).SelectMany(o => o.Photos);
                    else
                        photosQuery = dbContext.Organisms.Where(o => o.LatFirstName == names[0]).SelectMany(o => o.Photos);
                    break;
                case 3:
                    if (names[2] != "")
                        photosQuery = dbContext.People.Where(p => p.Name == names[0] && p.Surname == names[1] && p.Nickname == names[2]).SelectMany(p => p.Photos);
                    else
                        photosQuery = dbContext.People.Where(p => p.Name == names[0] && p.Surname == names[1]).SelectMany(p => p.Photos);
                    break;
            }
            (Category cat, DateTime frDate, DateTime untDate, string loc, string com) = photoInfo;
            if (cat != Category.All)
                photosQuery = photosQuery.Where(p => p.Category == cat);
            photosQuery = photosQuery.Where(p => p.TimeCreated.Date >= frDate.Date && p.TimeCreated.Date <= untDate.Date);
            if (loc != "")
                photosQuery = photosQuery.Where(p => p.Location.Contains(loc.Trim().ToLower()));
            if (com != "")
                photosQuery = photosQuery.Where(p => p.Comment.Contains(com.Trim().ToLower()));

            photosFound = photosQuery.OrderBy(p => p.TimeCreated).Select(p => p.FilePath).ToArray();
            return photosFound;
        }
            // Buď nic, nebo české, nebo latinské, nebo osoba. To vrátí věc/seznam věcí (ale jen query). Chci všechny fotky od té věci. Pak chci ty fotky projít a vyfiltrovat ještě
            // datum, místo, poznámku.
    }
}
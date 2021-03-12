﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DBioPhoto.DataAccess.Data;

namespace DBioPhoto.DataAccess.Services.Adding
{
    public class Suggestions
    {
        public static string[] GetOrganismNameSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            switch (textBoxNumber)
            {
                case 0:
                    return dbContext.Organisms.Where(o => o.FirstName.StartsWith(beginning.ToLower())).Select(o => o.FirstName).Distinct().ToArray();
                case 1:
                    return dbContext.Organisms.Where(o => o.SecondName.StartsWith(beginning.ToLower())).Select(o => o.SecondName).Distinct().ToArray();
                case 2:
                    return dbContext.Organisms.Where(o => o.LatFirstName.StartsWith(beginning.ToLower())).Select(o => o.LatFirstName).Distinct().ToArray();
                case 3:
                    return dbContext.Organisms.Where(o => o.LatSecondName.StartsWith(beginning.ToLower())).Select(o => o.LatSecondName).Distinct().ToArray();
                default:
                    return new string[0];
            }
        }

        public static string[] GetPhotoInfoSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            switch (textBoxNumber)
            {
                case 0:
                    return dbContext.Photos.Where(p => p.Location.StartsWith(beginning.ToLower())).Select(p => p.Location).Distinct().ToArray();
                case 1:
                    return dbContext.Photos.Where(p => p.Comment.StartsWith(beginning.ToLower())).Select(p => p.Comment).Distinct().ToArray();
                default:
                    return new string[0];
            }
        }

        public static string[] GetPhotoContentSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            switch (textBoxNumber)
            {
                case 0:
                    return dbContext.Organisms.Where(o => o.FirstName.StartsWith(beginning.ToLower()) || o.LatFirstName.StartsWith(beginning.ToLower()))
                        .Select(o => o.ToString()).Distinct().ToArray();
                case 1:
                    return dbContext.People.Where(p => p.Name.StartsWith(beginning.ToLower()) || p.Nickname.StartsWith(beginning.ToLower()))
                        .Select(p => p.ToString()).Distinct().ToArray();
                default:
                    return new string[0];
            }
        }
    }
}

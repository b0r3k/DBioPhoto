using DBioPhoto.DataAccess.Data;
using System.Collections.Generic;
using System.Linq;

namespace DBioPhoto.DataAccess.Services.Adding
{
    public class Suggestions
    {
        public static string[] GetOrganismNameSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            string[] suggestions;
            switch (textBoxNumber)
            {
                case 0:
                    suggestions = dbContext.Organisms.Where(o => o.FirstName.StartsWith(beginning.ToLower())).Select(o => o.FirstName).Distinct().ToArray();
                    break;
                case 1:
                    suggestions = dbContext.Organisms.Where(o => o.SecondName.StartsWith(beginning.ToLower())).Select(o => o.SecondName).Distinct().ToArray();
                    break;
                case 2:
                    suggestions = dbContext.Organisms.Where(o => o.LatFirstName.StartsWith(beginning.ToLower())).Select(o => o.LatFirstName).Distinct().ToArray();
                    break;
                case 3:
                    suggestions = dbContext.Organisms.Where(o => o.LatSecondName.StartsWith(beginning.ToLower())).Select(o => o.LatSecondName).Distinct().ToArray();
                    break;
                default:
                    suggestions = new string[0];
                    break;
            }
            return suggestions;
        }

        public static string[] GetPersonNameSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            string[] suggestions;
            switch (textBoxNumber)
            {
                case 0:
                    suggestions = dbContext.People.Where(p => p.Name.StartsWith(beginning.ToLower())).Select(p => p.Name).Distinct().ToArray();
                    break;
                case 1:
                    suggestions = dbContext.People.Where(p => p.Surname.StartsWith(beginning.ToLower())).Select(p => p.Surname).Distinct().ToArray();
                    break;
                case 2:
                    suggestions = dbContext.People.Where(p => p.Nickname.StartsWith(beginning.ToLower())).Select(p => p.Nickname).Distinct().ToArray();
                    break;
                default:
                    suggestions = new string[0];
                    break;
            }
            return suggestions;
        }

        public static string[] GetPhotoInfoSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            string[] suggestions;
            switch (textBoxNumber)
            {
                case 0:
                    suggestions = dbContext.Photos.Where(p => p.Location.StartsWith(beginning.ToLower())).Select(p => p.Location).Distinct().ToArray();
                    break;
                case 1:
                    suggestions = dbContext.Photos.Where(p => p.Comment.StartsWith(beginning.ToLower())).Select(p => p.Comment).Distinct().ToArray();
                    break;
                default:
                    suggestions = new string[0];
                    break;
            }
            return suggestions;
        }

        public static string[] GetPhotoContentSuggestions(DBioPhotoContext dbContext, string beginning, int textBoxNumber)
        {
            string[] suggestions;
            switch (textBoxNumber)
            {
                case 0:
                    suggestions = dbContext.Organisms.Where(o => o.FirstName.StartsWith(beginning.ToLower()) || o.LatFirstName.StartsWith(beginning.ToLower()))
                        .Select(o => o.ToString()).Distinct().ToArray();
                    break;
                case 1:
                    suggestions = dbContext.People
                        .Where(p => p.Name.StartsWith(beginning.ToLower()) || p.Nickname.StartsWith(beginning.ToLower()) || p.Surname.StartsWith(beginning.ToLower()))
                        .Select(p => p.ToString()).Distinct().ToArray();
                    break;
                default:
                    suggestions = new string[0];
                    break;
            }
            return suggestions;
        }
    }
}

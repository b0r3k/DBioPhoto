using System;
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
    }
}

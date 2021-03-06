using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using System.Linq;

namespace DBioPhoto.DataAccess.Services.Adding
{
    class AddIndividual
    {
        public static bool TryAddOrganism(DBioPhotoContext dbContext, Organism tryOrganism)
        {
            var possibleCollision = dbContext.Organisms
                                    .Where(o => o.FirstName == tryOrganism.FirstName)
                                    .Where(o => o.SecondName == tryOrganism.SecondName)
                                    .ToList();
            if (possibleCollision.Count > 0)
                return false;
            possibleCollision = dbContext.Organisms
                                    .Where(o => o.LatFirstName == tryOrganism.LatSecondName)
                                    .Where(o => o.LatSecondName == tryOrganism.LatSecondName)
                                    .ToList();
            if (possibleCollision.Count > 0)
                return false;
            else
            {
                dbContext.Organisms.Add(tryOrganism);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}

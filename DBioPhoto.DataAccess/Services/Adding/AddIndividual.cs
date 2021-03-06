using DBioPhoto.DataAccess.Data;
using DBioPhoto.Domain.Models;
using System.Linq;

namespace DBioPhoto.DataAccess.Services.Adding
{
    public class AddIndividual
    {
        public static string TryAddOrganism(DBioPhotoContext dbContext, Organism tryOrganism)
        {
            if (tryOrganism.FirstName == "" || tryOrganism.LatFirstName == "")
                return "Vyplňte název";
            var possibleCollision = dbContext.Organisms
                                    .Where(o => o.FirstName == tryOrganism.FirstName)
                                    .Where(o => o.SecondName == tryOrganism.SecondName)
                                    .ToList();
            if (possibleCollision.Count > 0)
                return "Organismus již existuje";
            possibleCollision = dbContext.Organisms
                                    .Where(o => o.LatFirstName == tryOrganism.LatFirstName)
                                    .Where(o => o.LatSecondName == tryOrganism.LatSecondName)
                                    .ToList();
            if (possibleCollision.Count > 0)
                return "Organismus již existuje";
            else
            {
                dbContext.Organisms.Add(tryOrganism);
                dbContext.SaveChanges();
                return "Úspěšně přidáno!";
            }
        }
    }
}

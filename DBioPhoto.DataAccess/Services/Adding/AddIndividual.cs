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
            else if (dbContext.Organisms
                                    .Any(o => o.FirstName == tryOrganism.FirstName
                                    && (o.SecondName == tryOrganism.SecondName)))
                return "Organismus již existuje";
            else if (dbContext.Organisms
                                    .Any(o => o.LatFirstName == tryOrganism.LatFirstName
                                    && (o.LatSecondName== tryOrganism.LatSecondName)))
                return "Organismus již existuje";
            else
            {
                dbContext.Organisms.Add(tryOrganism);
                return "Úspěšně přidáno!";
            }
        }

        public static string TryAddPerson(DBioPhotoContext dbContext, Person tryPerson)
        {
            if (tryPerson.Name == "" || tryPerson.Surname == "")
                return "Vyplňte jméno";
            else if (dbContext.People
                                    .Any(p => (p.Name == tryPerson.Name)
                                    && (p.Surname == tryPerson.Surname) 
                                    && (p.Nickname == tryPerson.Nickname)))
                return "Člověk již existuje";
            else
            {
                dbContext.People.Add(tryPerson);
                return "Úspěšně přidáno!";
            }
        }
    }
}

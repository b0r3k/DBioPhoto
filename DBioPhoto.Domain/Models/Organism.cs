using System;
using System.Collections.Generic;
using System.Text;

namespace DBioPhoto.Domain.Models
{
    public enum OrganismType { Plant, Animal, Fungus, Micro }
    public enum Colour { None, White, Red, Yellow, Green, Blue, Violet, Pink }

    public class Organism
    {
        public int Id { get; set; }
        public OrganismType OrganismType { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }
        public Colour Colour { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public Organism(OrganismType organismType, string firstName, string secondName, string latFirstName, string latSecondName, Colour colour)
        {
            OrganismType = organismType;
            FirstName = firstName;
            SecondName = secondName;
            LatFirstName = latFirstName;
            LatSecondName = latSecondName;
            Colour = colour;
        }
    }
}

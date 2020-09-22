using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBioPhoto.Domain.Models
{

    /*
    Zadám složku, ono to postupně otevírá fotky a nechává si dopsat informace

    -- typ -- krajina, rostliny, houby, živočichové, mikro, lidi - případně možnost přidat typ
    -- český a latinský název -- dělit na rodové a druhové jméno
    -- datum(na různých úrovních, měsíc, rok, rozmezí)
    -- lokalita, případně kreslit do mapy
    -- obecná textová poznámka
    -- případně u živočichů bezobratlí/obratlovci, při dalším přidání to už podle rodového jména doplní
    -- případně u rostlin byliny/stromy/keře/výtrusné
    -- barva květu -- bílá, žlutá, červená, růžová, fialová, zelená a nevytvořený, modrá
        -- kliknout na místo a z okolních pixelů vybrat barvu, která je nejblíž
    -- možná přístupná databáze biolib, ze které by se daly tahat další informace
    */

    /*
    Not using inheritance like Plant : Organism and Animal : Organism, because
    I need a special database table for each category.
     */

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<PersonOnPhoto> PersonOnPhotos { get; set; }
    }

    public enum BlossomColour { White, Red, Yellow, GreenOrNone, Blue, Violet, Pink }
    public class Plant
    {
        public int Id { get; set; }
        [Required]
        public BlossomColour BlossomColour { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }

        public ICollection<PlantOnPhoto> PlantOnPhotos { get; set; }
    }

    public class Animal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }

        public ICollection<AnimalOnPhoto> AnimalOnPhotos { get; set; }
    }

    public class Fungus
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }

        public ICollection<FungusOnPhoto> FungusOnPhotos { get; set; }
    }

    public class Micro
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }

        public ICollection<MicroOnPhoto> MicroOnPhotos { get; set; }
    }
}

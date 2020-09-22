using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBioPhoto.Models
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

    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    enum BlossomColour { White, Red, Yellow, GreenOrNone, Blue, Violet, Pink }
    class Plant
    {
        public int PlantId { get; set; }
        [Required]
        public BlossomColour BlossomColour { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }
    }

    class Animal
    {
        public int AnimalId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }
    }

    class Fungus
    {
        public int FungusId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }
    }

    class Micro
    {
        public int MicroId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LatFirstName { get; set; }
        public string LatSecondName { get; set; }
    }
}

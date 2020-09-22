using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DBioPhoto.Domain.Models
{
    public class PersonOnPhoto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int PhotoId { get; set; }

        public Person Person { get; set; }
        public Photo Photo { get; set; }
    }

    public class PlantOnPhoto
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int PhotoId { get; set; }

        public Plant Plant { get; set; }
        public Photo Photo { get; set; }
    }

    public class AnimalOnPhoto
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int PhotoId { get; set; }

        public Animal Animal { get; set; }
        public Photo Photo { get; set; }
    }

    public class FungusOnPhoto
    {
        public int Id { get; set; }
        public int FungusId { get; set; }
        public int PhotoId { get; set; }

        public Fungus Fungus { get; set; }
        public Photo Photo { get; set; }
    }

    public class MicroOnPhoto
    {
        public int Id { get; set; }
        public int MicroId { get; set; }
        public int PhotoId { get; set; }

        public Micro Micro { get; set; }
        public Photo Photo { get; set; }
    }
}

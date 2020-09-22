using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DBioPhoto.Domain.Models
{
    public enum Category { People, Countryside, Plants, Animals, Fungi, Micro }
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        public DateTime TimeCreated { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string FilePath { get; set; }
        [Required]
        public Category Category { get; set; }
        public string Comment { get; set; }
        public string Location { get; set; }

        public ICollection<PersonOnPhoto> PersonOnPhotos { get; set; }
        public ICollection<PlantOnPhoto> PlantOnPhotos { get; set; }
        public ICollection<AnimalOnPhoto> AnimalOnPhotos { get; set; }
        public ICollection<FungusOnPhoto> FungusOnPhotos { get; set; }
        public ICollection<MicroOnPhoto> MicroOnPhotos { get; set; }

    }
}

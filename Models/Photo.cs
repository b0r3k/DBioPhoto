using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DBioPhoto.Models
{
    enum Category { People, Countryside, Plants, Animals, Fungi, Micro }
    class Photo
    {
        public int PhotoId { get; set; }
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

        public ICollection<Person> People { get; set; }
        public ICollection<Plant> Plants { get; set; }
        public ICollection<Animal> Animals { get; set; }
        public ICollection<Fungus> Fungi { get; set; }
        public ICollection<Micro> Micros { get; set; }

    }
}

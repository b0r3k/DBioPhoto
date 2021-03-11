using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBioPhoto.Domain.Models
{
    public enum Category { People, Countryside, Plants, Animals, Fungi, Micro }
    public class Photo
    {
        public int Id { get; set; }
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
        public ICollection<Organism> Organisms { get; set; }

        public Photo(DateTime timeCreated, string fileName, string filePath, Category category, string comment, string location)
        {
            this.TimeCreated = timeCreated;
            this.FileName = fileName;
            this.FilePath = filePath;
            this.Category = category;
            this.Comment = comment;
            this.Location = location;
        }
    }
}

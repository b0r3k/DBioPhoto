using System;
using System.Collections.Generic;
using System.Text;

namespace DBioPhoto.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Surname { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}

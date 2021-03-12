using System.Collections.Generic;

namespace DBioPhoto.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Surname { get; set; }

        public List<Photo> Photos { get; set; }
        public Person(string name, string nickname, string surname)
        {
            Name = name;
            Nickname = nickname;
            Surname = surname;

            Photos = new List<Photo>();
        }
        public override string ToString()
            => Name + " '" + Nickname + "' " + Surname;
    }
}

using DataBaseWorker.Entites.Builders;
using System;

namespace DataBaseWorker
{
    public class EntityPerson
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBorn { get; set; }

        public EntityPerson() { }

        public EntityPerson(long iD, string firstName, string name, string lastName, DateTime dateOfBorn)
        {
            ID = iD;
            FirstName = firstName;
            Name = name;
            LastName = lastName;
            DateOfBorn = dateOfBorn;
        }

        public static PersonBuilder GetBuilder() => new PersonBuilder();
    }
}

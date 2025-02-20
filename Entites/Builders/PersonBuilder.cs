using System;

namespace DataBaseWorker.Entites.Builders
{
    public class PersonBuilder
    {
        private long ID;
        private string FirstName;
        private string Name;
        private string LastName;
        private DateTime DateOfBorn;

        public PersonBuilder SetId(long id)
        {
            ID = id;
            return this;
        }
        public PersonBuilder SetId(string id)
        {
            ID = Convert.ToInt64(id);
            return this;
        }
        public PersonBuilder SetFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }
        public PersonBuilder SetName(string name)
        {
            Name = name;
            return this;
        }
        public PersonBuilder SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }
        public PersonBuilder SetDateOfBorn(DateTime dateOfBorn)
        {
            DateOfBorn = dateOfBorn;
            return this;
        }
        public PersonBuilder SetDateOfBorn(string dateOfBorn)
        {
            DateOfBorn = DateTime.Parse(dateOfBorn);
            return this;
        }

        public EntityPerson Build() => new EntityPerson(ID, FirstName, Name, LastName, DateOfBorn);
    }
}

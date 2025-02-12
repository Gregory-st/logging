using System.Text;

namespace DataBaseWorker.Entites.Models
{
    public class ModelPerson : EntityPerson
    {
        public ModelPerson(EntityPerson person) : base(person.ID, person.FirstName, person.Name, person.LastName, person.DateOfBorn)
        { }

        public string GetDateOfBorn() => base.DateOfBorn.ToShortDateString();
        public string GetFullName() => new StringBuilder()
            .Append(base.FirstName)
            .Append(" ")
            .Append(base.Name)
            .Append(" ")
            .Append(base.LastName)
            .ToString();

        public static ModelPerson GetModel(EntityPerson EntityPerson) => new ModelPerson(EntityPerson);
    }
}

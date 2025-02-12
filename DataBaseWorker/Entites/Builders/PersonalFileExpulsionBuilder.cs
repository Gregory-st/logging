using System;

namespace DataBaseWorker.Entites.Builders
{
    public class PersonalFileExpulsionBuilder
    {
        private long id;
        private int course;
        private int baseClass;
        private ushort[] rating;
        private DateTime dateReceipt;
        private string speciality;
        private string group;
        private int idPerson;
        private int idBaseAdmission;
        private int idOrder;

        public PersonalFileExpulsionBuilder SetID(long ID)
        {
            id = ID;
            return this;
        }
        public PersonalFileExpulsionBuilder SetCourse(int Course)
        {
            Course = course;
            return this;
        }
        public PersonalFileExpulsionBuilder SetBaseClass(int BaseClass)
        {
            baseClass = BaseClass;
            return this;
        }
        public PersonalFileExpulsionBuilder SetDateReceipt(DateTime DateReceipt)
        {
            dateReceipt = DateReceipt;
            return this;
        }
        public PersonalFileExpulsionBuilder SetDateReceipt(string DateReceipt)
        {
            dateReceipt = DateTime.Parse(DateReceipt);
            return this;
        }
        public PersonalFileExpulsionBuilder SetSpeciality(string Speciality)
        {
            speciality = Speciality;
            return this;
        }
        public PersonalFileExpulsionBuilder SetGroup(string Group)
        {
            group = Group;
            return this;
        }
        public PersonalFileExpulsionBuilder SetIdPerson(int IdPerson)
        {
            idPerson = IdPerson;
            return this;
        }
        public PersonalFileExpulsionBuilder SetIdBaseAdmission(int IdBaseAdmission)
        {
            idBaseAdmission = IdBaseAdmission;
            return this;
        }
        public PersonalFileExpulsionBuilder SetIdOrder(int IdOrder)
        {
            idOrder = IdOrder;
            return this;
        }
        public PersonalFileExpulsionBuilder SetRatings(params int[] Ratings)
        {
            rating = new ushort[Ratings.Length];
            for (int i = 0; i < rating.Length; i++)
                rating[i] = Convert.ToUInt16(Math.Abs(Ratings[i]));
            return this;
        }

        public EntityPersonalFileExpulsion Build() => new EntityPersonalFileExpulsion(id, course, rating, baseClass, dateReceipt, speciality, group, idPerson, idBaseAdmission, idOrder);
    }
}

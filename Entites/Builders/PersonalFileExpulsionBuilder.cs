using System;

namespace DataBaseWorker.Entites.Builders
{
    public class PersonalFileExpulsionBuilder
    {
        private long id;
        private int course;
        private int baseClass;
        private ushort[] ratings;
        private DateTime dateReceipt;
        private string speciality;
        private string group;
        private int idPerson;
        private string BaseAdmission;
        private int idOrder;

        public PersonalFileExpulsionBuilder SetId(long ID)
        {
            id = ID;
            return this;
        }
        public PersonalFileExpulsionBuilder SetId(string ID)
        {
            id = Convert.ToInt64(ID);
            return this;
        }
        public PersonalFileExpulsionBuilder SetCourse(int Course)
        {
            course = Course;
            return this;
        }
        public PersonalFileExpulsionBuilder SetCourse(string Course)
        {
            course = Convert.ToInt32(Course);
            return this;
        }
        public PersonalFileExpulsionBuilder SetGroup(string Group)
        {
            group = Group;
            return this;
        }
        public PersonalFileExpulsionBuilder SetBaseClass(int BaseClass)
        {
            baseClass = BaseClass;
            return this;
        }
        public PersonalFileExpulsionBuilder SetBaseClass(string BaseClass)
        {
            baseClass = Convert.ToInt32(BaseClass);
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
        public PersonalFileExpulsionBuilder SetIdPerson(int IdPerson)
        {
            idPerson = IdPerson;
            return this;
        }
        public PersonalFileExpulsionBuilder SetIdPerson(string IdPerson)
        {
            idPerson = Convert.ToInt32(IdPerson);
            return this;
        }
        public PersonalFileExpulsionBuilder SetBaseAdmission(string BaseAdmission)
        {
            this.BaseAdmission = BaseAdmission;
            return this;
        }
        public PersonalFileExpulsionBuilder SetIdOrder(int IdOrder)
        {
            idOrder = IdOrder;
            return this;
        }
        public PersonalFileExpulsionBuilder SetIdOrder(string IdOrder)
        {
            idOrder = Convert.ToInt32(IdOrder);
            return this;
        }
        public PersonalFileExpulsionBuilder SetRatings(params int[] Ratings)
        {
            ratings = new ushort[Ratings.Length];
            for (int i = 0; i < ratings.Length; i++)
                ratings[i] = Convert.ToUInt16(Math.Abs(Ratings[i]));
            return this;
        }
        public PersonalFileExpulsionBuilder SetRatings(string Rating)
        {
            string[] rating = Rating.Split('/');
            ratings = new ushort[rating.Length];
            int j = 0;
            foreach (string i in rating)
            {
                ratings[j] = Convert.ToUInt16(i);
                j++;
            }
            return this;
        }

        public EntityPersonalFileExpulsion Build() => new EntityPersonalFileExpulsion(id, course, ratings, baseClass, dateReceipt, speciality, group, idPerson, BaseAdmission, idOrder);
    }
}

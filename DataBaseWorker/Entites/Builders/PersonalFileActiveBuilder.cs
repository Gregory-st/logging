using System;

namespace DataBaseWorker.Entites.Builders
{
    public class PersonalFileActiveBuilder
    {
        private long id;
        private int course;
        private int baseClass;
        private DateTime dateReceipt;
        private string speciality;
        private int idPerson;
        private int idBaseAdmission;
        private int idTransfer;
        private int idGroup;

        public PersonalFileActiveBuilder SetId(long Id)
        {
            id = Id;
            return this;
        }
        public PersonalFileActiveBuilder SetCourse(int Course)
        {
            course = Course;
            return this;
        }
        public PersonalFileActiveBuilder SetBaseClass(int BaseClass)
        {
            baseClass = BaseClass;
            return this;
        }
        public PersonalFileActiveBuilder SetDateReceipt(DateTime DateReceipt)
        {
            dateReceipt = DateReceipt;
            return this;
        }
        public PersonalFileActiveBuilder SetDateReceipt(string DateReceipt)
        {
            dateReceipt = DateTime.Parse(DateReceipt);
            return this;
        }
        public PersonalFileActiveBuilder SetSpeciality(string Speciality)
        {
            speciality = Speciality;
            return this;
        }
        public PersonalFileActiveBuilder SetIdPerson(int IdPerson)
        {
            idPerson = IdPerson;
            return this;
        }
        public PersonalFileActiveBuilder SetIdBaseAdmission(int IdBaseAdmission)
        {
            idBaseAdmission = IdBaseAdmission;
            return this;
        }
        public PersonalFileActiveBuilder SetIdTransfer(int IdTransfer)
        {
            idTransfer = IdTransfer;
            return this;
        }
        public PersonalFileActiveBuilder SetIdGroup(int IdGroup)
        {
            idGroup = IdGroup;
            return this;
        }

        public EntityPersonalFileActive Builder() => new EntityPersonalFileActive(id, course, baseClass, dateReceipt, speciality, idPerson, idBaseAdmission, idTransfer, idGroup);
    }
}

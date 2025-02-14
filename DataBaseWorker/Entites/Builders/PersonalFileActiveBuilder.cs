﻿using System;

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
        public PersonalFileActiveBuilder SetId(string Id)
        {
            id = Convert.ToInt64(Id);
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
        public PersonalFileActiveBuilder SetBaseClass(string BaseClass)
        {
            baseClass = Convert.ToInt32(BaseClass);
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
        public PersonalFileActiveBuilder SetIdPerson(string IdPerson)
        {
            idPerson = Convert.ToInt32(IdPerson);
            return this;
        }
        public PersonalFileActiveBuilder SetIdBaseAdmission(int IdBaseAdmission)
        {
            idBaseAdmission = IdBaseAdmission;
            return this;
        }
        public PersonalFileActiveBuilder SetIdBaseAdmission(string IdBaseAdmission)
        {
            idBaseAdmission = Convert.ToInt32(IdBaseAdmission);
            return this;
        }
        public PersonalFileActiveBuilder SetIdTransfer(int IdTransfer)
        {
            idTransfer = IdTransfer;
            return this;
        }
        public PersonalFileActiveBuilder SetIdTransfer(string IdTransfer)
        {
            idTransfer = Convert.ToInt32(IdTransfer);
            return this;
        }
        public PersonalFileActiveBuilder SetIdGroup(string IdGroup)
        {
            idGroup = Convert.ToInt32(IdGroup);
            return this;
        }

        public EntityPersonalFileActive Builder() => new EntityPersonalFileActive(id, course, baseClass, dateReceipt, speciality, idPerson, idBaseAdmission, idTransfer, idGroup);
    }
}

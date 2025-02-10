using System;

namespace DataBaseWorker.Entites
{
    public class EntityPersonalFileActive
    {
        public long ID { get; set; }
        public int Course { get; set; }
        public int BaseClass { get; set; }
        public DateTime DateReceipt { get; set; }
        public string Speciality { get; set; }
        public int IdPerson { get; set; }
        public int IdBaseAdmission { get; set; }
        public int IdTransfer { get; set; }
        public int IdGroup { get; set; }

        public EntityPersonalFileActive()
        {
        }

        public EntityPersonalFileActive(long iD, int course, int baseClass, DateTime dateReceipt, string speciality, int idPerson, int idBaseAdmission, int idTransfer, int idGroup)
        {
            ID = iD;
            Course = course;
            BaseClass = baseClass;
            DateReceipt = dateReceipt;
            Speciality = speciality;
            IdPerson = idPerson;
            IdBaseAdmission = idBaseAdmission;
            IdTransfer = idTransfer;
            IdGroup = idGroup;
        }
    }
}

using System;

namespace DataBaseWorker.Entites
{
    public class EntityPersonalFileEnd
    {
        public long ID { get; set; }
        public int Course { get; set; }
        public int BaseClass { get; set; }
        public DateTime DateReceipt { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public int IdPerson { get; set; }
        public int IdBaseAdmission { get; set; }
        public int IdOrder { get; set; }

        public EntityPersonalFileEnd()
        {
        }

        public EntityPersonalFileEnd(long iD, int course, int baseClass, DateTime dateReceipt, string speciality, string group, int idPerson, int idBaseAdmission, int idOrder)
        {
            ID = iD;
            Course = course;
            BaseClass = baseClass;
            DateReceipt = dateReceipt;
            Speciality = speciality;
            Group = group;
            IdPerson = idPerson;
            IdBaseAdmission = idBaseAdmission;
            IdOrder = idOrder;
        }
    }
}

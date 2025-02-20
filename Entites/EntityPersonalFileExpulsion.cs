using System;
using System.Collections.Generic;

namespace DataBaseWorker.Entites
{
    public class EntityPersonalFileExpulsion
    {
        public long ID { get; set; }
        public int Course { get; set; }
        public int BaseClass { get; set; }
        public DateTime DateReceipt { get; set; }
        public readonly List<ushort> Ratings;
        public string Speciality { get; set; }
        public string Group { get; set; }
        public int IdPerson { get; set; }
        public string BaseAdmission { get; set; }
        public int IdOrder { get; set; }

        public EntityPersonalFileExpulsion()
        {
            Ratings = new List<ushort>();
        }

        public EntityPersonalFileExpulsion(long iD, int course, ushort[] ratings, int baseClass, DateTime dateReceipt, string speciality, string group, int idPerson, string BaseAdmission, int idOrder)
        {
            ID = iD;
            Course = course;
            BaseClass = baseClass;
            DateReceipt = dateReceipt;
            Speciality = speciality;
            Group = group;
            IdPerson = idPerson;
            this.BaseAdmission = BaseAdmission;
            IdOrder = idOrder;
            Ratings = new List<ushort>();
            Ratings.AddRange(ratings);
        }

        public static Builders.PersonalFileExpulsionBuilder GetBuilder() => new Builders.PersonalFileExpulsionBuilder(); 
    }
}

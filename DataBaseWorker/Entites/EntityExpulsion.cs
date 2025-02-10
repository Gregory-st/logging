using System;
using System.Collections.Generic;

namespace DataBaseWorker.Entites
{
    public class EntityExpulsion
    {
        public long ID { get; set; }
        public string Cause { get; set; }
        public List<ushort> Ratings { get; } = new List<ushort>();
        public int Course { get; set; }
        public string Group { get; set; }
        public string Speciality { get; set; }
        public DateTime DateOrder { get; set; }

        public EntityExpulsion()
        {
        }

        public EntityExpulsion(long iD, string cause, int course, string group, string speciality, DateTime dateOrder)
        {
            ID = iD;
            Cause = cause;
            Course = course;
            Group = group;
            Speciality = speciality;
            DateOrder = dateOrder;
        }
    }
}

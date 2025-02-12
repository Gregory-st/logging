using System;
using System.Collections.Generic;

namespace DataBaseWorker.Entites
{
    public class EntityExpulsion
    {
        public long ID { get; set; }
        public string Cause { get; set; }                                                                                                                                                               
        public readonly List<ushort> Ratings;
        public int Course { get; set; }
        public string Group { get; set; }
        public string Speciality { get; set; }
        public DateTime DateOrder { get; set; }

        public EntityExpulsion()
        {
            Ratings = new List<ushort>();
        }

        public EntityExpulsion(long iD, string cause, ushort[] ratings, int course, string group, string speciality, DateTime dateOrder)
        {
            ID = iD;
            Cause = cause;
            Course = course;
            Group = group;
            Speciality = speciality;
            DateOrder = dateOrder;
            Ratings = new List<ushort>();
            Ratings.AddRange(ratings);
        }

        public static Builders.ExpulsionBuilder GetBuilder() => new Builders.ExpulsionBuilder();
    }
}

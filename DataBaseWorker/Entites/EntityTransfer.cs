using System.Collections.Generic;

namespace DataBaseWorker.Entites
{
    public class EntityTransfer
    {
        public long ID { get; set; }
        public string Trigger { get; set; }
        public List<ushort> Ratings { get; }
        public int Course { get; set; }
        public string Speciality { get; set; }

        public EntityTransfer(long iD, string trigger, List<ushort> ratings, int course, string speciality)
        {
            ID = iD;
            Trigger = trigger;
            Ratings = ratings;
            Course = course;
            Speciality = speciality;
        }

        public EntityTransfer()
        {
        }
    }
}

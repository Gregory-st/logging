using System.Collections.Generic;

namespace DataBaseWorker.Entites
{
    public class EntityTransfer
    {
        public long ID { get; set; }
        public string Trigger { get; set; }
        public readonly List<ushort> Rating;
        public int Course { get; set; }
        public string Special { get; set; }

        public EntityTransfer(long iD, string trigger, ushort[] rating, int course, string special)
        {
            ID = iD;
            Trigger = trigger;
            Course = course;
            Special = special;
            Rating = new List<ushort>();
            Rating.AddRange(rating);
        }

        public EntityTransfer()
        {
        }

        public static Builders.TransferBuilder GetBulder() => new Builders.TransferBuilder();
    }
}

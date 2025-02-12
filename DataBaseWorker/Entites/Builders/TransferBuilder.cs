using System;

namespace DataBaseWorker.Entites.Builders
{
    public class TransferBuilder
    {
        private long id;
        private string trigger;
        private ushort[] ratings;
        private int course;
        private string special;

        public TransferBuilder SetId(long Id)
        {
            id = Id;
            return this;
        }
        public TransferBuilder SetTrigger(string Trigger)
        {
            trigger = Trigger;
            return this;
        }
        public TransferBuilder SetRatings(params int[] Ratings)
        {
            ratings = new ushort[Ratings.Length];
            for (int i = 0; i < ratings.Length; i++)
                ratings[i] =Convert.ToUInt16(Math.Abs(Ratings[i]));
            return this;
        }
        public TransferBuilder SetCourse(int Course)
        {
            course = Course;
            return this;
        }
        public TransferBuilder SetSpecial(string Special)
        {
            special = Special;
            return this;
        }

        public EntityTransfer Build() => new EntityTransfer(id, trigger, ratings, course, special);
    }
}

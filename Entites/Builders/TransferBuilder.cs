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
        public TransferBuilder SetId(string Id)
        {
            id = Convert.ToInt64(Id);
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
        public TransferBuilder SetRatings(string Rating)
        {
            string[] rating = Rating.Split('/');
            ratings = new ushort[rating.Length];
            int j = 0;
            foreach (string i in rating)
            {
                ratings[j] = Convert.ToUInt16(i);
                j++;
            }
            return this;
        }
        public TransferBuilder SetCourse(int Course)
        {
            course = Course;
            return this;
        }
        public TransferBuilder SetCourse(string Course)
        {
            course = Convert.ToInt32(Course);
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

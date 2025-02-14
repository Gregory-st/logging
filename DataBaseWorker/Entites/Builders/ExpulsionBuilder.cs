using System;

namespace DataBaseWorker.Entites.Builders
{
    public class ExpulsionBuilder
    {
        private long id;
        private string cause;
        private ushort[] ratings;
        private int course;
        private string group;
        private string speciality;
        private DateTime dateOrder;

        public ExpulsionBuilder SetId(long Id)
        {
            id = Id;
            return this;
        }
        public ExpulsionBuilder SetId(string Id)
        {
            id = Convert.ToInt64(Id);
            return this;
        }
        public ExpulsionBuilder SetCause(string Cause)
        {
            cause = Cause;
            return this;
        }
        public ExpulsionBuilder SetRatings(params int[] Ratings)
        {
            ratings = new ushort[Ratings.Length];
            int j = 0;
            foreach(int i in Ratings)
            {
                ratings[j] = Convert.ToUInt16(Math.Abs(i));
                j++;
            }
            return this;
        }
        public ExpulsionBuilder SetRatings(string Rating)
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
        public ExpulsionBuilder SetCourse(int Course)
        {
            course = Course;
            return this;
        }
        public ExpulsionBuilder SetCourse(string Course)
        {
            course = Convert.ToInt32(Course);
            return this;
        }
        public ExpulsionBuilder SetGroup(string Group)
        {
            group = Group;
            return this;
        }
        public ExpulsionBuilder SetSpeciality(string Speciality)
        {
            speciality = Speciality;
            return this;
        }
        public ExpulsionBuilder SetDateOrder(DateTime DateOrder)
        {
            dateOrder = DateOrder;
            return this;
        }
        public ExpulsionBuilder SetDateOrder(string DateOrder)
        {
            dateOrder = DateTime.Parse(DateOrder);
            return this;
        }

        public EntityExpulsion Build() => new EntityExpulsion(id, cause, ratings, course, group, speciality, dateOrder);
    }
}

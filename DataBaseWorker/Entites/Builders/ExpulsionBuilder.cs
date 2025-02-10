using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ExpulsionBuilder SetCourse(int Course)
        {
            course = Course;
            return this;
        }
    }
}

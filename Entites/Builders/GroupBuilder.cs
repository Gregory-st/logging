using System;

namespace DataBaseWorker.Entites.Builders
{
    public class GroupBuilder
    {
        private long ID;
        private string Name;
        private ushort Count;
        private int Max;
        private int Course;
        private int Number;

        public GroupBuilder SetId(long id)
        {
            ID = id;
            return this;
        }
        public GroupBuilder SetId(string id)
        {
            ID = Convert.ToInt64(id);
            return this;
        }
        public GroupBuilder SetName(string name)
        {
            Name = name; 
            return this;
        }
        public GroupBuilder SetCount(int count)
        {
            Count = Convert.ToUInt16(Math.Abs(count));
            return this;
        }
        public GroupBuilder SetCount(string count)
        {
            Count = Convert.ToUInt16(count);
            return this;
        }
        public GroupBuilder SetMax(int max)
        {
            Max = max;
            return this;
        }
        public GroupBuilder SetMax(string max)
        {
            Max = Convert.ToInt32(max);
            return this;
        }
        public GroupBuilder SetCourse(int course)
        {
            Course = course;
            return this;
        }
        public GroupBuilder SetCourse(string course)
        {
            Course = Convert.ToInt32(course);
            return this;
        }
        public GroupBuilder SetNumber(int number)
        {
            Number = number;
            return this;
        }
        public GroupBuilder SetNumber(string number)
        {
            Number = Convert.ToInt32(number);
            return this;
        }

        public EntityGroup Build() => new EntityGroup(ID, Name, Count, Max, Course, Number);
    }
}

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
        public GroupBuilder SetMax(int max)
        {
            Max = max;
            return this;
        }
        public GroupBuilder SetCourse(int course)
        {
            Course = course;
            return this;
        }
        public GroupBuilder SetNumber(int number)
        {
            Number = number;
            return this;
        }

        public EntityGroup Build() => new EntityGroup(ID, Name, Count, Max, Course, Number);
    }
}

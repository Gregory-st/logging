using DataBaseWorker.Entites.Builders;

namespace DataBaseWorker.Entites
{
    public class EntityGroup
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public ushort Count { get; set; }
        public int Max { get; set; }
        public int Course { get; set; }
        public int Number { get; set; }

        public EntityGroup() { }

        public EntityGroup(long iD, string name, ushort count, int max, int course, int number)
        {
            ID = iD;
            Name = name;
            Count = count;
            Max = max;
            Course = course;
            Number = number;
        }

        public static GroupBuilder GetBuilder() => new GroupBuilder();
    }
}

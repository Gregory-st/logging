using System.Text;

namespace DataBaseWorker.Entites.Models
{
    public class ModelGroup : EntityGroup
    {
        public ModelGroup(EntityGroup group) : base(group.ID, group.Name, group.Count, group.Max, group.Course, group.Number)
        { }

        public string GetTitle() => new StringBuilder()
            .Append(base.Name)
            .Append("-")
            .Append(base.Course)
            .Append(base.Number)
            .ToString();

        public int CountStudent => base.Count;

        public static ModelGroup GetModel(EntityGroup Group) => new ModelGroup(Group);
    }
}

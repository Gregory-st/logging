using System.Text;

namespace DataBaseWorker.Entites.Models
{
    public class ModelTransfer : EntityTransfer
    {
        public ModelTransfer(EntityTransfer entity) : base(entity.ID, entity.Trigger, entity.Rating.ToArray(), entity.Course, entity.Special)
        { }
        public ModelTransfer() { }
        public string GetRatings()
        {
            StringBuilder builder = new StringBuilder();
            foreach (ushort i in base.Rating)
                builder.Append(i.ToString()).Append('/');
            builder = builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }
    }
}

using System.Text;

namespace DataBaseWorker.Entites.Models
{
    public class ModelExpulsion : EntityExpulsion
    {
        public ModelExpulsion(EntityExpulsion entity) : base(entity.ID, entity.Cause, entity.Ratings.ToArray(), entity.Course, entity.Group, entity.Speciality, entity.DateOrder) 
        { }

        public string GetRating()
        {
            StringBuilder line = new StringBuilder();
            foreach(ushort i in base.Ratings)
                line.Append(i.ToString()).Append("/");
            line = line.Remove(line.Length - 1, 1);
            return line.ToString();
        }
        public string GetDateOfString() => base.DateOrder.ToShortDateString();

        public static ModelExpulsion GetModel(EntityExpulsion EntityExpulsion) => new ModelExpulsion(EntityExpulsion);
    }
}

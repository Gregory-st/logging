using System.Text;

namespace DataBaseWorker.Entites.Models
{
    public class ModelPersonalExpulsion : EntityPersonalFileExpulsion
    {
        public ModelPersonalExpulsion(EntityPersonalFileExpulsion expulsion) : base(expulsion.ID, expulsion.Course, expulsion.Ratings.ToArray(), expulsion.BaseClass, expulsion.DateReceipt, expulsion.Speciality, expulsion.Group, expulsion.IdPerson, expulsion.IdBaseAdmission, expulsion.IdOrder)
        { }

        public string GetDate() => base.DateReceipt.ToShortDateString();
        public string GetRating()
        {
            StringBuilder line = new StringBuilder();
            foreach (ushort i in base.Ratings)
                line.Append(i.ToString()).Append("/");
            line = line.Remove(line.Length - 1, 1);
            return line.ToString();
        }

        public static ModelExpulsion GetModel(EntityExpulsion expulsion) => new ModelExpulsion(expulsion);
    }
}

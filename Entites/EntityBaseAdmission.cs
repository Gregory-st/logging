using DataBaseWorker.Entites.Builders;

namespace DataBaseWorker.Entites
{
    public class EntityBaseAdmission
    {
        public long ID { get; set; }
        public string Name { get; set; }

        public EntityBaseAdmission() { }

        public EntityBaseAdmission(long iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public static BaseAdmissionBuilder GetBuilder() => new BaseAdmissionBuilder();
    }
}

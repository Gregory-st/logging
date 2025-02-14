using System;

namespace DataBaseWorker.Entites.Builders
{
    public class BaseAdmissionBuilder
    {
        private long id;
        private string name;

        public BaseAdmissionBuilder SetId(long ID)
        {
            id = ID;
            return this;
        }
        public BaseAdmissionBuilder SetId(string ID)
        {
            id = Convert.ToInt64(ID);
            return this;
        }
        public BaseAdmissionBuilder SetName(string Name) 
        {
            name = Name;
            return this;
        }

        public EntityBaseAdmission Build() => new EntityBaseAdmission(id, name);
    }
}

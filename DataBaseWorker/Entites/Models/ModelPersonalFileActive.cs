namespace DataBaseWorker.Entites.Models
{
    public class ModelPersonalFileActive : EntityPersonalFileActive
    {
        public ModelPersonalFileActive(EntityPersonalFileActive active) : base(active.ID, active.Course, active.BaseClass, active.DateReceipt, active.Speciality, active.IdPerson, active.IdBaseAdmission, active.IdTransfer, active.IdGroup)
        { }

        public string GetDate() => base.DateReceipt.ToShortDateString();
        public static ModelPersonalFileActive GetModel(EntityPersonalFileActive active) => new ModelPersonalFileActive(active);
    }
}

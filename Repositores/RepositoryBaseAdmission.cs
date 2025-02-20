using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryBaseAdmission
    {
        private readonly OleDataBaseContext context;

        public RepositoryBaseAdmission(OleDataBaseContext context)
        {
            this.context = context;
        }

        public EntityBaseAdmission[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.BaseAdmissions.Fill(data);
            table = data.Tables[0];

            EntityBaseAdmission[] admissions = new EntityBaseAdmission[table.Rows.Count];
            for(int i = 0; i < admissions.Length; i++)
            {
                admissions[i] = EntityBaseAdmission
                    .GetBuilder()
                    .SetId(table.Rows[i][0].ToString())
                    .SetName(table.Rows[i][1].ToString())
                    .Build();
            }
            context.CloseConnect();
            return admissions;
        }
        public EntityBaseAdmission GetById(long ID) => Array.Find(Get(), i => i.ID == ID) 
            ?? throw new Exception();
        public EntityBaseAdmission GetByName(string Name) => Array.Find(Get(), i => i.Name == Name) 
            ?? throw new Exception();

        public void Add(EntityBaseAdmission admission)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.BaseAdmissions.Fill(data);
            table = data.Tables[0];

            DataRow row = table.NewRow();
            row[0] = admission.ID;
            row[1] = admission.Name;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.BaseAdmissions);
            context.BaseAdmissions.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityBaseAdmission oldAdmission, EntityBaseAdmission admission)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.BaseAdmissions.Fill(data);
            table = data.Tables[0];

            DataRow row = null;
            foreach (DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldAdmission.ID.ToString())
                {
                    row = i;
                    break;
                }
            }
            if (row == null) throw new Exception();

            row[0] = admission.ID;
            row[1] = admission.Name;

            oldAdmission.ID = admission.ID;
            oldAdmission.Name = admission.Name;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.BaseAdmissions);
            context.BaseAdmissions.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.BaseAdmissions.Fill(data);
            table = data.Tables[0];

            DataRow row = null;
            foreach(DataRow i in table.Rows)
            {
                if(i[0].ToString() == ID.ToString())
                {
                    row = i;
                    break;
                }
            }
            if (row == null) throw new Exception();
            row.Delete();

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.BaseAdmissions);
            context.BaseAdmissions.Update(data);
            context.CloseConnect();
        }
        public void Delete(EntityBaseAdmission admission) => DeleteAt(admission.ID);
    }
}

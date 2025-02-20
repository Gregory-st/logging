using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryFilePersonalExplusion
    {
        private readonly OleDataBaseContext context;

        public RepositoryFilePersonalExplusion(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelPersonalExpulsion[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.PersonalFilesExpulsing.Fill(data);
            table = data.Tables[0];

            ModelPersonalExpulsion[] explFiles = new ModelPersonalExpulsion[table.Rows.Count];
            for (int i = 0; i < explFiles.Length; i++)
            {
                explFiles[i] = new ModelPersonalExpulsion(EntityPersonalFileExpulsion
                    .GetBuilder()
                    .SetId(table.Rows[i]["Код"].ToString())
                    .SetIdOrder(table.Rows[i]["Код_приказа"].ToString())
                    .SetBaseClass(table.Rows[i]["Класс"].ToString())
                    .SetDateReceipt(table.Rows[i]["Дата_поступления"].ToString())
                    .SetCourse(table.Rows[i]["Курс"].ToString())
                    .SetGroup(table.Rows[i]["Группа"].ToString())
                    .SetSpeciality(table.Rows[i]["Специальность"].ToString())
                    .SetIdPerson(table.Rows[i]["Код_персоны"].ToString())
                    .SetBaseAdmission(table.Rows[i]["База_поступления"].ToString())
                    .Build()
                    );
            }
            context.CloseConnect();
            return explFiles;
        }

        public void Add(EntityPersonalFileExpulsion fileExpl)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;

            context.OpenConnect();
            context.PersonalFilesExpulsing.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row[0] = fileExpl.ID;
            row[1] = fileExpl.IdOrder;
            row[2] = fileExpl.BaseClass;
            row[3] = fileExpl.DateReceipt.ToShortDateString();
            row[4] = fileExpl.Course;
            row[5] = fileExpl.Group;
            row[6] = fileExpl.Speciality;
            row[7] = fileExpl.IdPerson;
            row[8] = fileExpl.BaseAdmission;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesExpulsing);
            context.PersonalFilesExpulsing.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityPersonalFileExpulsion oldFileExpl, EntityPersonalFileExpulsion fileExpl)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesExpulsing.Fill(data);
            table = data.Tables[0];

            foreach (DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldFileExpl.ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            oldFileExpl.ID = fileExpl.ID;
            oldFileExpl.IdOrder = fileExpl.IdOrder;
            oldFileExpl.BaseClass = fileExpl.BaseClass;
            oldFileExpl.DateReceipt = fileExpl.DateReceipt;
            oldFileExpl.Course = fileExpl.Course;
            oldFileExpl.Group = fileExpl.Group;
            oldFileExpl.Speciality = fileExpl.Speciality;
            oldFileExpl.IdPerson = fileExpl.IdPerson;
            oldFileExpl.BaseAdmission = fileExpl.BaseAdmission;

            row[0] = fileExpl.ID;
            row[1] = fileExpl.IdOrder;
            row[2] = fileExpl.BaseClass;
            row[3] = fileExpl.DateReceipt.ToShortDateString();
            row[4] = fileExpl.Course;
            row[5] = fileExpl.Group;
            row[6] = fileExpl.Speciality;
            row[7] = fileExpl.IdPerson;
            row[8] = fileExpl.BaseAdmission;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesExpulsing);
            context.PersonalFilesExpulsing.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesExpulsing.Fill(data);
            table = data.Tables[0];

            foreach (DataRow i in table.Rows)
            {
                if (i[0].ToString() == ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();
            row.Delete();

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesExpulsing);
            context.PersonalFilesExpulsing.Update(data);
            context.CloseConnect();
        }

        public void Delete(EntityPersonalFileExpulsion fileExpl) => DeleteAt(fileExpl.ID);
    }
}

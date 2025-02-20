using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryFilePersonalEnding
    {
        private readonly OleDataBaseContext context;

        public RepositoryFilePersonalEnding(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelPersonalExpulsion[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.PersonalFilesEnding.Fill(data);
            table = data.Tables[0];

            ModelPersonalExpulsion[] endingFiles = new ModelPersonalExpulsion[table.Rows.Count];
            for (int i = 0; i < endingFiles.Length; i++)
            {
                endingFiles[i] = new ModelPersonalExpulsion(EntityPersonalFileExpulsion
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
            return endingFiles;
        }

        public void Add(EntityPersonalFileExpulsion fileEnding)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;

            context.OpenConnect();
            context.PersonalFilesEnding.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row[0] = fileEnding.ID;
            row[1] = fileEnding.IdOrder;
            row[2] = fileEnding.BaseClass;
            row[3] = fileEnding.DateReceipt.ToShortDateString();
            row[4] = fileEnding.Course;
            row[5] = fileEnding.Group;
            row[6] = fileEnding.Speciality;
            row[7] = fileEnding.IdPerson;
            row[8] = fileEnding.BaseAdmission;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesEnding);
            context.PersonalFilesEnding.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityPersonalFileExpulsion oldFileEnding, EntityPersonalFileExpulsion fileEnding)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesEnding.Fill(data);
            table = data.Tables[0];

            foreach(DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldFileEnding.ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            oldFileEnding.ID = fileEnding.ID;
            oldFileEnding.IdOrder = fileEnding.IdOrder;
            oldFileEnding.BaseClass = fileEnding.BaseClass;
            oldFileEnding.DateReceipt = fileEnding.DateReceipt;
            oldFileEnding.Course = fileEnding.Course;
            oldFileEnding.Group = fileEnding.Group;
            oldFileEnding.Speciality = fileEnding.Speciality;
            oldFileEnding.IdPerson = fileEnding.IdPerson;
            oldFileEnding.BaseAdmission = fileEnding.BaseAdmission;

            row[0] = fileEnding.ID;
            row[1] = fileEnding.IdOrder;
            row[2] = fileEnding.BaseClass;
            row[3] = fileEnding.DateReceipt.ToShortDateString();
            row[4] = fileEnding.Course;
            row[5] = fileEnding.Group;
            row[6] = fileEnding.Speciality;
            row[7] = fileEnding.IdPerson;
            row[8] = fileEnding.BaseAdmission;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesEnding);
            context.PersonalFilesEnding.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesEnding.Fill(data);
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

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesEnding);
            context.PersonalFilesEnding.Update(data);
            context.CloseConnect();
        }

        public void Delete(EntityPersonalFileExpulsion fileEnding) => DeleteAt(fileEnding.ID);
    }
}

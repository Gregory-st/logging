using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryPersonalFileTranspher
    {
        private readonly OleDataBaseContext context;

        public RepositoryPersonalFileTranspher(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelPersonalExpulsion[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.PersonalFilesTransfering.Fill(data);
            table = data.Tables[0];

            ModelPersonalExpulsion[] tranFiles = new ModelPersonalExpulsion[table.Rows.Count];
            for (int i = 0; i < tranFiles.Length; i++)
            {
                tranFiles[i] = new ModelPersonalExpulsion(EntityPersonalFileExpulsion
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
            return tranFiles;
        }

        public ModelPersonalExpulsion GetById(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.PersonalFilesTransfering.Fill(data);
            table = data.Tables[0];

            ModelPersonalExpulsion tranFile = null;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToInt64(table.Rows[i][0]) != ID) continue;
                tranFile = new ModelPersonalExpulsion(EntityPersonalFileExpulsion
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
                break;
            }
            context.CloseConnect();
            return tranFile;
        }

        public void Add(EntityPersonalFileExpulsion fileTransp)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;

            context.OpenConnect();
            context.PersonalFilesTransfering.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row[0] = fileTransp.ID;
            row[1] = fileTransp.IdOrder;
            row[2] = fileTransp.BaseClass;
            row[3] = fileTransp.DateReceipt.ToShortDateString();
            row[4] = fileTransp.Course;
            row[5] = fileTransp.Group;
            row[6] = fileTransp.Speciality;
            row[7] = fileTransp.IdPerson;
            row[8] = fileTransp.BaseAdmission;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesTransfering);
            context.PersonalFilesTransfering.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityPersonalFileExpulsion oldFileTransp, EntityPersonalFileExpulsion fileTransp)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesTransfering.Fill(data);
            table = data.Tables[0];

            foreach (DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldFileTransp.ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            oldFileTransp.ID = fileTransp.ID;
            oldFileTransp.IdOrder = fileTransp.IdOrder;
            oldFileTransp.BaseClass = fileTransp.BaseClass;
            oldFileTransp.DateReceipt = fileTransp.DateReceipt;
            oldFileTransp.Course = fileTransp.Course;
            oldFileTransp.Group = fileTransp.Group;
            oldFileTransp.Speciality = fileTransp.Speciality;
            oldFileTransp.IdPerson = fileTransp.IdPerson;
            oldFileTransp.BaseAdmission = fileTransp.BaseAdmission;

            row[0] = fileTransp.ID;
            row[1] = fileTransp.IdOrder;
            row[2] = fileTransp.BaseClass;
            row[3] = fileTransp.DateReceipt.ToShortDateString();
            row[4] = fileTransp.Course;
            row[5] = fileTransp.Group;
            row[6] = fileTransp.Speciality;
            row[7] = fileTransp.IdPerson;
            row[8] = fileTransp.BaseAdmission;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesTransfering);
            context.PersonalFilesTransfering.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesTransfering.Fill(data);
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

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesTransfering);
            context.PersonalFilesTransfering.Update(data);
            context.CloseConnect();
        }

        public void Delete(EntityPersonalFileExpulsion fileTransp) => DeleteAt(fileTransp.ID);
    }
}

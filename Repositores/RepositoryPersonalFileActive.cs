using DataBaseWorker.Comparators;
using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DataBaseWorker.Repositores
{
    public class RepositoryPersonalFileActive
    {
        private readonly OleDataBaseContext context;

        public RepositoryPersonalFileActive(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelPersonalFileActive[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.PersonalFilesActive.Fill(data);
            table = data.Tables[0];

            ModelPersonalFileActive[] activeFiles = new ModelPersonalFileActive[table.Rows.Count];
            for (int i = 0; i < activeFiles.Length; i++)
            {
                activeFiles[i] = new ModelPersonalFileActive(EntityPersonalFileActive
                    .GetBuilder()
                    .SetId(table.Rows[i]["Код"].ToString())
                    .SetIdBaseAdmission(table.Rows[i]["Код_базы_поступления"].ToString())
                    .SetCourse(table.Rows[i]["Курс"].ToString())
                    .SetBaseClass(table.Rows[i]["Класс"].ToString())
                    .SetDateReceipt(table.Rows[i]["Дата_поступления"].ToString())
                    .SetSpeciality(table.Rows[i]["Специальность"].ToString())
                    .SetIdPerson(table.Rows[i]["Код_персоны"].ToString())
                    .SetIdTransfer(table.Rows[i]["Код_перевода"].ToString())
                    .SetIdGroup(table.Rows[i]["Код_группы"].ToString())
                    .Build()
                    );
            }
            context.CloseConnect();
            return activeFiles;
        }

        public ModelPersonalFileActive[] GetSortByGroups()
        {
            ModelPersonalFileActive[] actives = Get();
            Array.Sort(actives, new ComparatorPersonalFileActive());
            return actives;
        }

        public void Add(EntityPersonalFileActive fileActive)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;

            context.OpenConnect();
            context.PersonalFilesActive.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row[0] = fileActive.ID;
            row[1] = fileActive.IdBaseAdmission;
            row[2] = fileActive.Course;
            row[3] = fileActive.BaseClass;
            row[4] = fileActive.DateReceipt.ToShortDateString();
            row[5] = fileActive.Speciality;
            row[6] = fileActive.IdPerson;
            row[7] = fileActive.IdTransfer;
            row[8] = fileActive.IdGroup;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesActive);
            context.PersonalFilesActive.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityPersonalFileActive oldFileActive, EntityPersonalFileActive fileActive)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesActive.Fill(data);
            table = data.Tables[0];
            
            foreach(DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldFileActive.ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            oldFileActive.ID = fileActive.ID;
            oldFileActive.IdBaseAdmission = fileActive.IdBaseAdmission;
            oldFileActive.Course = fileActive.Course;
            oldFileActive.BaseClass = fileActive.BaseClass;
            oldFileActive.DateReceipt = fileActive.DateReceipt;
            oldFileActive.Speciality = fileActive.Speciality;
            oldFileActive.IdPerson = fileActive.IdPerson;
            oldFileActive.IdTransfer = fileActive.IdTransfer;
            oldFileActive.IdGroup = fileActive.IdGroup;

            row[0] = fileActive.ID;
            row[1] = fileActive.IdBaseAdmission;
            row[2] = fileActive.Course;
            row[3] = fileActive.BaseClass;
            row[4] = fileActive.DateReceipt.ToShortDateString();
            row[5] = fileActive.Speciality;
            row[6] = fileActive.IdPerson;
            row[7] = fileActive.IdTransfer;
            row[8] = fileActive.IdGroup;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesActive);
            context.PersonalFilesActive.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.PersonalFilesActive.Fill(data);
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

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.PersonalFilesActive);
            context.PersonalFilesActive.Update(data);
            context.CloseConnect();
        }
        public void Delete(EntityPersonalFileActive fileActive) => DeleteAt(fileActive.ID);
    }
}

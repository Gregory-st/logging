using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryExpulsion
    {
        private readonly OleDataBaseContext context;

        public RepositoryExpulsion(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelExpulsion[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.Expulsions.Fill(data);
            table = data.Tables[0];

            ModelExpulsion[] expulsions = new ModelExpulsion[table.Rows.Count];
            for(int i = 0; i < expulsions.Length; i++)
            {
                expulsions[i] = new ModelExpulsion(EntityExpulsion
                    .GetBuilder()
                    .SetId(table.Rows[i]["Код"].ToString())
                    .SetCause(table.Rows[i]["Причина"].ToString())
                    .SetCourse(table.Rows[i]["Курс"].ToString())
                    .SetDateOrder(table.Rows[i]["Дата_приказа"].ToString())
                    .SetGroup(table.Rows[i]["Группа"].ToString())
                    .SetRatings(table.Rows[i]["Оценки"].ToString())
                    .SetSpeciality(table.Rows[i]["Специальность"].ToString())
                    .Build()
                    );
            }
            context.CloseConnect();
            return expulsions;
        }
        public ModelExpulsion GetById(long ID) => Array.Find(Get(), i => i.ID == ID) ?? throw new Exception();
        public ModelExpulsion[] GetByCause(string Cause) => Array.FindAll(Get(), i => i.Cause == Cause) ?? throw new Exception();
        public ModelExpulsion[] GetByGroup(string Group) => Array.FindAll(Get(), i => i.Group == Group) ?? throw new Exception();
        public ModelExpulsion[] GetBySpeciality(string Speciality) => Array.FindAll(Get(), i => i.Group == Speciality) ?? throw new Exception();

        public void Add(EntityExpulsion expulsion)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;
            ModelExpulsion modelExpulsion = new ModelExpulsion(expulsion);

            context.OpenConnect();
            context.Expulsions.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row["Код"] = modelExpulsion.ID;
            row["Причина"] = modelExpulsion.Cause;
            row["Курс"] = modelExpulsion.Course;
            row["Дата_приказа"] = modelExpulsion.GetDateOfString();
            row["Группа"] = modelExpulsion.Group;
            row["Оценки"] = modelExpulsion.GetRating();
            row["Специальность"] = modelExpulsion.Speciality;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Expulsions);
            context.Expulsions.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityExpulsion oldExpulsion, EntityExpulsion expulsion)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;
            ModelExpulsion modelExpulsion = new ModelExpulsion(expulsion);

            context.OpenConnect();
            context.Expulsions.Fill(data);
            table = data.Tables[0];
            
            foreach(DataRow i in table.Rows)
            {
                if (i["Код"].ToString() == oldExpulsion.ID.ToString())
                    row = i;
            }

            if (row == null) throw new Exception();

            row["Код"] = modelExpulsion.ID;
            row["Причина"] = modelExpulsion.Cause;
            row["Курс"] = modelExpulsion.Course;
            row["Дата_приказа"] = modelExpulsion.GetDateOfString();
            row["Группа"] = modelExpulsion.Group;
            row["Оценки"] = modelExpulsion.GetRating();
            row["Специальность"] = modelExpulsion.Speciality;

            oldExpulsion.ID = expulsion.ID;
            oldExpulsion.Cause = expulsion.Cause;
            oldExpulsion.Course = expulsion.Course;
            oldExpulsion.DateOrder = expulsion.DateOrder;
            oldExpulsion.Group = expulsion.Group;
            oldExpulsion.Ratings.Clear();
            oldExpulsion.Ratings.AddRange(expulsion.Ratings.ToArray());
            oldExpulsion.Speciality = expulsion.Speciality;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Expulsions);
            context.Expulsions.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.Expulsions.Fill(data);
            table = data.Tables[0];

            DataRow row = null;
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

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Expulsions);
            context.Expulsions.Update(data);
            context.CloseConnect();
        }
        public void Delete(EntityExpulsion expulsion)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.Expulsions.Fill(data);
            table = data.Tables[0];

            DataRow row = null;
            foreach (DataRow i in table.Rows)
            {
                if (i[0].ToString() == expulsion.ID.ToString())
                {
                    row = i;
                    break;
                }
            }
            if (row == null) throw new Exception();
            row.Delete();

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Expulsions);
            context.Expulsions.Update(data);
            context.CloseConnect();
        }
    }
}

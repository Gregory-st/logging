using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;


namespace DataBaseWorker.Repositores
{
    public class RepositoryGroup
    {
        private readonly OleDataBaseContext context;

        public RepositoryGroup(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelGroup[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;
            ModelGroup[] groups;

            context.OpenConnect();
            context.Groups.Fill(data);
            table = data.Tables[0];

            groups = new ModelGroup[table.Rows.Count];
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new ModelGroup(EntityGroup
                    .GetBuilder()
                    .SetId(table.Rows[i]["Код"].ToString())
                    .SetName(table.Rows[i]["Буква"].ToString())
                    .SetCount(table.Rows[i]["Количество"].ToString())
                    .SetMax(table.Rows[i]["Максимум"].ToString())
                    .SetCourse(table.Rows[i]["Курс"].ToString())
                    .SetNumber(table.Rows[i]["Номер"].ToString())
                    .Build());
            }

            context.CloseConnect();
            return groups;
        }

        private ModelGroup[] GetByAttrib(string NameAttrib, object Val, string Message)
        {
            List<ModelGroup> groups = new List<ModelGroup>();
            foreach (ModelGroup i in Get())
            {
                switch (NameAttrib)
                {
                    case nameof(i.ID): if (i.ID.ToString() == Val.ToString()) groups.Add(i); break;
                    case nameof(i.Name): if (i.Name == Val.ToString()) groups.Add(i); break;
                    case nameof(i.Count): if (i.Count.ToString() == Val.ToString()) groups.Add(i); break;
                    case nameof(i.Max): if (i.Max.ToString() == Val.ToString()) groups.Add(i); break;
                    case nameof(i.Course): if (i.Course.ToString() == Val.ToString()) groups.Add(i); break;
                    case nameof(i.Number): if (i.Number.ToString() == Val.ToString()) groups.Add(i); break;
                    case "Title": if (i.GetTitle() == Val.ToString()) groups.Add(i); break;
                }
            }
            if (groups.Count == 0) throw new Exception(Message);
            return groups.ToArray();
        }
        public ModelGroup GetById(long ID) => GetByAttrib(nameof(ID), ID, "Группа с данным идентификатором не найдена").First();
        public ModelGroup[] GetByName(string Name) => GetByAttrib(nameof(Name), Name, "Группа с данным именем не найдена");
        public ModelGroup[] GetByCount(int Count) => GetByAttrib(nameof(Count), Count, "Группа с данным количеством не найдена");
        public ModelGroup[] GetByCourse(int Course) => GetByAttrib(nameof(Course), Course, "Группа с данным курсом не найдена");
        public ModelGroup[] GetByNumber(int Number) => GetByAttrib(nameof(Number), Number, "Группа с данным номером не найдена");
        public ModelGroup GetByTitle(string Title) => GetByAttrib(nameof(Title), Title, "Группа не найдена").First();

        public void Add(EntityGroup group)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;

            context.OpenConnect();
            context.Groups.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row["Код"] = group.ID;
            row["Буква"] = group.Name;
            row["Количество"] = group.Count;
            row["Максимум"] = group.Max;
            row["Курс"] = group.Course;
            row["Номер"] = group.Number;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Groups);
            context.Groups.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.Groups.Fill(data);
            table = data.Tables[0];

            DataRow row = null;

            foreach(DataRow i in table.Rows)
            {
                if(i["Код"].ToString() == ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            row.Delete();
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Groups);
            context.Groups.Update(data);
            context.CloseConnect();
        }
        public void Delete(EntityGroup group) => DeleteAt(group.ID);

        public void Update(ref EntityGroup oldGroup, EntityGroup group)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.Groups.Fill(data);
            table = data.Tables[0];

            DataRow row = null;

            foreach (DataRow i in table.Rows)
            {
                if (i["Код"].ToString() == oldGroup.ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            oldGroup.ID = group.ID;
            oldGroup.Name = group.Name;
            oldGroup.Count = group.Count;
            oldGroup.Max = group.Max;
            oldGroup.Number = group.Number;
            oldGroup.Number = group.Number;

            row["Код"] = group.ID;
            row["Буква"] = group.Name;
            row["Количество"] = group.Count;
            row["Максимум"] = group.Max;
            row["Курс"] = group.Course;
            row["Номер"] = group.Number;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Groups);
            context.Groups.Update(data);
            context.CloseConnect();
        }
    }
}

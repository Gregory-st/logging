using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryDictionaryCourse
    {
        private readonly OleDataBaseContext context;

        public RepositoryDictionaryCourse(OleDataBaseContext context)
        {
            this.context = context;
        }

        public EntityDictionaryCourse Get()
        {
            DataSet data = new DataSet();
            DataTable table;

            context.DictionaryCourses.Fill(data);
            table = data.Tables[0];

            EntityDictionaryCourse dictionary = new EntityDictionaryCourse();
            foreach(DataRow i in table.Rows)
                dictionary.Add(i[0].ToString(), i[1].ToString());

            return dictionary;
        }

        public void Add(string Character, string Description)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;

            context.OpenConnect();
            context.DictionaryCourses.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row[0] = Character;
            row[1] = Description;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.DictionaryCourses);
            context.DictionaryCourses.Update(data);
            context.CloseConnect();
        }

        public void Update(string oldCharacter, string oldDescription, string Character, string Description)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.DictionaryCourses.Fill(data);
            table = data.Tables[0];
            
            foreach(DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldCharacter && i[1].ToString() == oldDescription)
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            row[0] = Character;
            row[1] = Description;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.DictionaryCourses);
            context.DictionaryCourses.Update(data);
            context.CloseConnect();
        }

        public void Delete(string Character, string Description)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.DictionaryCourses.Fill(data);
            table = data.Tables[0];

            foreach (DataRow i in table.Rows)
            {
                if (i[0].ToString() == Character && i[1].ToString() == Description)
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();
            row.Delete();

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.DictionaryCourses);
            context.DictionaryCourses.Update(data);
            context.CloseConnect();
        }
    }
}

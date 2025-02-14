using DataBaseWorker.Context;
using DataBaseWorker.Entites.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryPerson
    {
        private readonly OleDataBaseContext context;

        public RepositoryPerson(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelPerson[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;
            ModelPerson[] persons;

            context.OpenConnect();
            context.Persons.Fill(data);
            table = data.Tables[0];

            persons = new ModelPerson[table.Rows.Count];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new ModelPerson(EntityPerson
                    .GetBuilder()
                    .SetId(table.Rows[i][0].ToString())
                    .SetFirstName(table.Rows[i][1].ToString())
                    .SetName(table.Rows[i][2].ToString())
                    .SetLastName(table.Rows[i][3].ToString())
                    .SetDateOfBorn(table.Rows[i][4].ToString())
                    .Build());
            }
            context.CloseConnect();

            return persons;
        }
        public ModelPerson GetByID(long ID)
        {
            foreach(ModelPerson i in Get())
            {
                if (i.ID == ID)
                    return i;
            }
            throw new Exception();
        }
        private ModelPerson[] GetAttribOfName(string Attrib, string Val, string Message)
        {
            List<ModelPerson> person = new List<ModelPerson>();
            foreach(ModelPerson i in Get())
            {
                switch (Attrib)
                {
                    case nameof(i.FirstName): if (i.FirstName == Val) person.Add(i); break;
                    case nameof(i.Name): if (i.Name == Val) person.Add(i); break;
                    case nameof(i.LastName): if (i.LastName == Val) person.Add(i); break;
                    case nameof(i.DateOfBorn): if (i.GetDateOfBorn() == Val) person.Add(i); break;
                }
            }
            if (person.Count == 0) throw new Exception(Message);
            return person.ToArray();
        }
        public ModelPerson[] GetByFirstName(string FirstName) => GetAttribOfName(nameof(FirstName), FirstName, "Пользователь с данной фамилией не найден");
        public ModelPerson[] GetByName(string Name) => GetAttribOfName(nameof(Name), Name, "Пользователь с данным именем не найден");
        public ModelPerson[] GetByLastName(string LastName) => GetAttribOfName(nameof(LastName), LastName, "Пользователь с данным отчеством не найден");
        public ModelPerson[] GetByDateBorn(string DateOfBorn) => GetAttribOfName(nameof(DateOfBorn), DateOfBorn, "Пользователь с данным днём рождения не найден");

        public void Add(EntityPerson person)
        {
            DataSet data = new DataSet();
            DataTable table;
            ModelPerson Person = new ModelPerson(person);

            context.OpenConnect();
            context.Persons.Fill(data);
            table = data.Tables[0];

            DataRow row = table.NewRow();
            row[0] = Person.ID;
            row[1] = Person.FirstName;
            row[2] = Person.Name;
            row[3] = Person.LastName;
            row[4] = Person.GetDateOfBorn();

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Persons);
            context.Persons.Update(data);
            context.CloseConnect();
        }

        public void Delete(EntityPerson person) => DeleteAt(person.ID);
        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;

            context.OpenConnect();
            context.Persons.Fill(data);
            table = data.Tables[0];

            DataRow row = null;
            foreach (DataRow i in table.Rows)
            {
                if (ID == Convert.ToInt64(i[0]))
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            row.Delete();
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Persons);
            context.Persons.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityPerson oldPerson, EntityPerson person)
        {
            DataSet data = new DataSet();
            DataTable table;
            ModelPerson model = new ModelPerson(person);

            context.OpenConnect();
            context.Persons.Fill(data);
            table = data.Tables[0];

            DataRow row = null;
            foreach (DataRow i in table.Rows)
            {
                if (oldPerson.ID == Convert.ToInt64(i[0]))
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            row[0] = model.ID;
            row[1] = model.FirstName;
            row[2] = model.Name;
            row[3] = model.LastName;
            row[4] = model.GetDateOfBorn();

            oldPerson.ID = model.ID;
            oldPerson.FirstName = model.FirstName;
            oldPerson.Name = model.Name;
            oldPerson.LastName = model.LastName;
            oldPerson.DateOfBorn = model.DateOfBorn;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Persons);
            context.Persons.Update(data);
            context.CloseConnect();
        }
    }
}

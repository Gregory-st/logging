using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
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

            return expulsions;
        }
        public ModelExpulsion GetById(long ID) => Array.Find(Get(), i => i.ID == ID) ?? throw new Exception();
        public ModelExpulsion[] GetByCause(string Cause) => Array.FindAll(Get(), i => i.Cause == Cause) ?? throw new Exception();
        public ModelExpulsion[] GetByGroup(string Group) => Array.FindAll(Get(), i => i.Group == Group) ?? throw new Exception();
        public ModelExpulsion[] GetBySpeciality(string Speciality) => Array.FindAll(Get(), i => i.Group == Speciality) ?? throw new Exception();
    }
}

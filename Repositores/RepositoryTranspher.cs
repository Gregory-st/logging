using DataBaseWorker.Context;
using DataBaseWorker.Entites;
using DataBaseWorker.Entites.Models;
using System;
using System.Data;
using System.Data.OleDb;

namespace DataBaseWorker.Repositores
{
    public class RepositoryTranspher
    {
        private readonly OleDataBaseContext context;

        public RepositoryTranspher(OleDataBaseContext context)
        {
            this.context = context;
        }

        public ModelTransfer[] Get()
        {
            DataSet data = new DataSet();
            DataTable table;
            ModelTransfer[] transfers;

            context.OpenConnect();
            context.Transfers.Fill(data);
            table = data.Tables[0];

            transfers = new ModelTransfer[table.Rows.Count];
            for(int i = 0; i < transfers.Length; i++)
            {
                transfers[i] = new ModelTransfer(EntityTransfer
                    .GetBulder()
                    .SetId(table.Rows[i][0].ToString())
                    .SetTrigger(table.Rows[i][1].ToString())
                    .SetRatings(table.Rows[i][2].ToString())
                    .SetCourse(table.Rows[i][3].ToString())
                    .SetSpecial(table.Rows[i][4].ToString())
                    .Build());
            }

            context.CloseConnect();
            return transfers;
        }

        public void Add(EntityTransfer transfer)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row;
            ModelTransfer transfer1 = new ModelTransfer(transfer);

            context.OpenConnect();
            context.Transfers.Fill(data);
            table = data.Tables[0];
            row = table.NewRow();

            row[0] = transfer1.ID;
            row[1] = transfer1.Trigger;
            row[2] = transfer1.GetRatings();
            row[3] = transfer1.Course;
            row[4] = transfer1.Special;

            table.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Transfers);
            context.Transfers.Update(data);
            context.CloseConnect();
        }

        public void Update(ref EntityTransfer oldTransfer, EntityTransfer transfer)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;
            ModelTransfer transfer1 = new ModelTransfer(transfer);

            context.OpenConnect();
            context.Transfers.Fill(data);
            table = data.Tables[0];

            foreach(DataRow i in table.Rows)
            {
                if (i[0].ToString() == oldTransfer.ID.ToString())
                {
                    row = i;
                    break;
                }
            }

            if (row == null) throw new Exception();

            oldTransfer.ID = transfer.ID;
            oldTransfer.Trigger = transfer.Trigger;
            oldTransfer.Rating.Clear();
            oldTransfer.Rating.AddRange(transfer.Rating.ToArray());
            oldTransfer.Course = transfer.Course;
            oldTransfer.Special = transfer.Special;

            row[0] = transfer1.ID;
            row[1] = transfer1.Trigger;
            row[2] = transfer1.GetRatings();
            row[3] = transfer1.Course;
            row[4] = transfer1.Special;

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Transfers);
            context.Transfers.Update(data);
            context.CloseConnect();
        }

        public void DeleteAt(long ID)
        {
            DataSet data = new DataSet();
            DataTable table;
            DataRow row = null;

            context.OpenConnect();
            context.Transfers.Fill(data);
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

            OleDbCommandBuilder builder = new OleDbCommandBuilder(context.Transfers);
            context.Transfers.Update(data);
            context.CloseConnect();
        }

        public void Delete(EntityTransfer transfer) => DeleteAt(transfer.ID);
    }
}

using System.Data.OleDb;
using System.IO;
using System.Text;

namespace DataBaseWorker.Context
{
    public class OleConnectionContext
    {
        protected readonly OleDbConnection connection;
        public string TableAdmissions { get; set; }
        public string TableDictionary { get; set; }
        public string TableExpulsion { get; set; }
        public string TablePerson { get; set; }
        public string TableGroup { get; set; }
        public string TableActive { get; set; }
        public string TableEnding { get; set; }
        public string TableTransfering { get; set; }
        public string TableExpulsing { get; set; }
        public string TableTransfer { get; set; }

        public OleConnectionContext(OleDbConnectionStringBuilder connection)
        {
            this.connection = new OleDbConnection(connection.ConnectionString);
        }

        public OleConnectionContext()
        {
            connection = new OleDbConnection();
        }

        public void OpenConnect() => connection.Open();
        public void CloseConnect() => connection.Close();

        public void SaveConfigInFile()
        {
            FileStream file = new FileStream(@"config\connect.txt", FileMode.Create, FileAccess.Write);
            BufferedStream buffered = new BufferedStream(file);
            StreamWriter writer = new StreamWriter(buffered);

            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine(connection.Provider)
                .AppendLine(connection.Database)
                .AppendLine(connection.DataSource)
                .Append(nameof(TableAdmissions)).Append(":").Append(TableAdmissions)
                .AppendLine()
                .Append(nameof(TableDictionary)).Append(":").Append(TableDictionary)
                .AppendLine()
                .Append(nameof(TableExpulsion)).Append(":").Append(TableExpulsion)
                .AppendLine()
                .Append(nameof(TablePerson)).Append(":").Append(TablePerson)
                .AppendLine()
                .Append(nameof(TableGroup)).Append(":").Append(TableGroup)
                .AppendLine()
                .Append(nameof(TableActive)).Append(":").Append(TableActive)
                .AppendLine()
                .Append(nameof(TableEnding)).Append(":").Append(TableEnding)
                .AppendLine()
                .Append(nameof(TableTransfering)).Append(":").Append(TableTransfering)
                .AppendLine()
                .Append(nameof(TableExpulsing)).Append(":").Append(TableExpulsing)
                .AppendLine()
                .Append(nameof(TableTransfer)).Append(":").Append(TableTransfer);

            writer.Write(builder.ToString());

            writer.Flush();
            writer.Close();
            file.Close();
        }

        protected void DefaultConnection()
        {
            connection.ConnectionString = new OleDbConnectionStringBuilder()
            { 
                Provider = "Microsoft.ACE.OLEDB.12.0",
                DataSource = "Учебная часть.accdb"
            }
            .ToString();
        }

        public virtual void OpenConfigOfFile()
        {
            string[] lines = File.ReadAllLines(@"config\connect.txt");

            if (!Directory.Exists("config")) Directory.CreateDirectory("config");

            if (!File.Exists(@"config\connect.txt")) 
            {
                DefaultConnection();
                SaveConfigInFile();
            };

            if (File.Exists(lines[2]))
                lines[2] = lines[1];

            if (!File.Exists(lines[2]))
                throw new Exceptions.NotFoundFileDataBaseException("Не корректные данные");

            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder()
            {
                Provider = lines[0],
                DataSource = lines[1]
            };

            connection.ConnectionString = builder.ConnectionString;

            TableAdmissions = lines[3].Split(':')[1];
            TableDictionary = lines[4].Split(':')[1];
            TableExpulsion = lines[5].Split(':')[1];
            TablePerson = lines[6].Split(':')[1];
            TableGroup = lines[7].Split(':')[1];
            TableActive = lines[8].Split(':')[1];
            TableEnding = lines[9].Split(':')[1];
            TableTransfering = lines[10].Split(':')[1];
            TableExpulsing = lines[11].Split(':')[1];
            TableTransfer = lines[12].Split(':')[1];
        }
    }
}

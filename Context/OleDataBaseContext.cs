using System.Data.OleDb;

namespace DataBaseWorker.Context
{
    public class OleDataBaseContext : OleConnectionContext
    {
        private const string pattern = "SELECT * FROM {0};";

        public OleDbDataAdapter BaseAdmissions { get; private set; }
        public OleDbDataAdapter DictionaryCourses { get; private set; }
        public OleDbDataAdapter Expulsions { get; private set; }
        public OleDbDataAdapter Persons { get; private set; }
        public OleDbDataAdapter Groups { get; private set; }
        public OleDbDataAdapter PersonalFilesActive { get; private set; }
        public OleDbDataAdapter PersonalFilesEnding { get; private set; }
        public OleDbDataAdapter PersonalFilesTransfering { get; private set; }
        public OleDbDataAdapter PersonalFilesExpulsing { get; private set; }
        public OleDbDataAdapter Transfers { get; private set; }

        public OleDataBaseContext(OleDbConnectionStringBuilder connection) : base(connection)
        {
            base.OpenConnect();

            BaseAdmissions = new OleDbDataAdapter(string.Format(pattern, TableAdmissions), base.connection);
            DictionaryCourses = new OleDbDataAdapter(string.Format(pattern, TableDictionary), base.connection);
            Expulsions = new OleDbDataAdapter(string.Format(pattern, TableExpulsion), base.connection);
            Persons = new OleDbDataAdapter(string.Format(pattern, TablePerson), base.connection);
            Groups = new OleDbDataAdapter(string.Format(pattern, TableGroup), base.connection);
            PersonalFilesActive = new OleDbDataAdapter(string.Format(pattern, TableActive), base.connection);
            PersonalFilesEnding = new OleDbDataAdapter(string.Format(pattern, TableEnding), base.connection);
            PersonalFilesTransfering = new OleDbDataAdapter(string.Format(pattern, TableTransfering), base.connection);
            PersonalFilesExpulsing = new OleDbDataAdapter(string.Format(pattern, TableExpulsing), base.connection);
            Transfers = new OleDbDataAdapter(string.Format(pattern, TableTransfer), base.connection);

            base.CloseConnect();
        }

        public OleDataBaseContext() { }
    }
}

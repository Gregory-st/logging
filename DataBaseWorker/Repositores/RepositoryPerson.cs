using DataBaseWorker.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseWorker.Repositores
{
    public class RepositoryPerson
    {
        private readonly OleDataBaseContext context;

        public RepositoryPerson(OleDataBaseContext context)
        {
            this.context = context;
        }
    }
}

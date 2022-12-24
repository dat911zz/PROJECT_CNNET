using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Sys.Containers
{
    public class ServicesContainer
    {
        Service service;
        DBHelper db;
        DataSet ds;
        DataColumn[] key;

        public ServicesContainer(Service service, DBHelper db, DataSet ds, DataColumn[] key)
        {
            Service = service;
            Db = db;
            Ds = ds;
            Key = key;
        }

        public Service Service { get => service; set => service = value; }
        public DBHelper Db { get => db; set => db = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public DataColumn[] Key { get => key; set => key = value; }
    }
}

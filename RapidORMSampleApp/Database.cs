using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RapidORM.Data;

namespace RapidORMSampleApp
{
    public class Database
    {
        public static void UseDb()
        {
            DBContext.ConnectionString = new DBConnection()
            {
                Server = "",
                Database = "",
                Username = "",
                Password = ""
            };
        }
    }
}

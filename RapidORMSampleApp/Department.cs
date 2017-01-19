using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RapidORM.Data;
using RapidORM.Helpers;
using RapidORM.Attributes;
using RapidORM.Interfaces;
using RapidORM.Client.MySQL;
using RapidORM.Common;

namespace RapidORMSampleApp
{
    [TableName("department")]
    public class Department
    {
        [IsPrimaryKey(true)]
        [ColumnName("id")]
        public int Id { get; set; }

        [ColumnName("name")]
        public string Name { get; set; }

        [ColumnName("date_created")]
        public string DateCreated { get; set; }

        private IDBEntity<Department> dbEntity = null;

        public Department()
        {
            dbEntity = new MySqlEntity<Department>();
        }

        public Department(Dictionary<string, object> args)
        {
            Id = Convert.ToInt32(args["id"].ToString());
            Name = args["name"].ToString();
            DateCreated = args["date_created"].ToString();
        }

        #region Class Methods
        public void Save(Department department)
        {
            dbEntity.SaveChanges(department);
        } 

        public void DeleteDepartmentByObject(Department department)
        {
            dbEntity.DeleteObject(department);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            IEnumerable<Department> departments = dbEntity.GetAllObjects();

            return (departments.Count() > 0) ? departments : null;
        }        
        #endregion
    }
}

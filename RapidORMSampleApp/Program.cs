using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RapidORM.Helpers;

namespace RapidORMSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.UseDb();
            Department departmentInstance = new Department();

            #region Save data
            departmentInstance.Save(new Department
            {
                Name = "New Department",
                DateCreated = DateHelper.GetDateTimeForDB()
            });
            #endregion

            #region Update data
            //To update, simply add the Id of the record
            //departmentInstance.Save(new Department
            //{
            //    Id = 10,
            //    Name = "New Department Updated",
            //    DateCreated = DateHelper.GetDateTimeForDB()
            //});
            #endregion

            #region Delete data            
            //To delete, you only need to use the Id of the record
            //departmentInstance.DeleteDepartmentByObject(new Department
            //{
            //    Id = 10
            //});
            #endregion

            #region Display data
            var departments = departmentInstance.GetAllDepartments();
            foreach (var department in departments)
            {
                Console.WriteLine(department.Id  + " - " + 
                    department.Name + " -" + department.DateCreated);
            }
            #endregion

            Console.Read();
        }
    }
}

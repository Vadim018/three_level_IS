using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MM2
{
    internal class TaskServiceBLL
    {
        DBItemDAL<Task> dbTask;

        DBItemDAL<Department> dbDepartment;

        public TaskServiceBLL(DBItemDAL<Task> dbTask, DBItemDAL<Department> dbDepartment)
        {
            this.dbTask = dbTask;
            this.dbDepartment = dbDepartment;
        }

       
        public List<TaskDepartmentVM> GetTasksByDepartmens()
        {

            List<TaskDepartmentVM> tasks = new List<TaskDepartmentVM>();

            foreach (Task t in dbTask.Items)
            {
                foreach (Department d in t.Departments)
                {
                    tasks.Add(new TaskDepartmentVM(t.TName, d.DName));
                }
            }
            return tasks;
        }
         
        public List<Task> GetTasksByDepartmentName(string dName)
        {
            List<Task> tasks = new List<Task>();

            foreach (Department d in dbDepartment.Items)
            {
                if (d.DName == dName)
                {           
                    tasks.AddRange(d.Tasks);
                }
            }
            return tasks;
        }
    }
}
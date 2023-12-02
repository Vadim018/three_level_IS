using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class TaskServicePL
    {
        TaskServiceBLL taskServiceBLL;

        public TaskServicePL(TaskServiceBLL taskServiceBLL)
        {
            this.taskServiceBLL = taskServiceBLL;
        }

        public void GetTasksByDepartmens()
        {

            List<TaskDepartmentVM> tasks = taskServiceBLL.GetTasksByDepartmens();

            foreach (TaskDepartmentVM t in tasks)
            {
                Console.WriteLine(t);
            }
        }

        public void GetTasksByDepartmentName()
        {
            Console.Write("ВВЕДІТЬ НАЗВУ ВІДДІЛУ: ");
            string name = Console.ReadLine();

            List<Task> tasks = taskServiceBLL.GetTasksByDepartmentName(name);

            foreach (Task task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
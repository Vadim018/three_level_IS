/*
-------------------------------------------------------------------------------------------------------
    Завдання MM2
-------------------------------------------------------------------------------------------------------
    Створити трирівневу інформаційну систему з підтримки діяльності відділу контролю виконання завдань.
    Існує декілька відділів. Наприклад: відділ1, відділ2, відділ3.
    Існує декілька завдань. Наприклад: завдання1, завдання2, завдання3.

    Співвиконавцем кожного завдання є декілька відділів.
-------------------------------------------------------------------------------------------------------
    Наприклад: 
    завдання1:  відділ1,  відділ3.
    завдання2:  відділ2,  відділ3.
    завдання3:  відділ1,  відділ2.
-------------------------------------------------------------------------------------------------------
    Інформаційна система повинна:
    * вивести всі завдання. Кожне завдання з відділами, які його виконують.
    * по введеній назві відділу надавати назви всіх завдань цього відділу.
-------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DBItemDAL<Task> dbTask = new DBItemDAL<Task>();
            
            Task task1 = new Task("T1");
            Task task2 = new Task("T2");
            Task task3 = new Task("T3");

            dbTask.Add(task1);
            dbTask.Add(task2);
            dbTask.Add(task3);

            DBItemDAL<Department> dbDepartment = new DBItemDAL<Department>();

            Department department1 = new Department("D1");
            Department department2 = new Department("D2");
            Department department3 = new Department("D3");

            dbDepartment.Add(department1);
            dbDepartment.Add(department2);
            dbDepartment.Add(department3);

            task1.Departments.Add(department1);
            task1.Departments.Add(department3);

            task2.Departments.Add(department2);
            task2.Departments.Add(department3);

            task3.Departments.Add(department1);
            task3.Departments.Add(department2);

            department1.Tasks.Add(task1);
            department3.Tasks.Add(task1);

            department2.Tasks.Add(task2);
            department3.Tasks.Add(task2);

            department1.Tasks.Add(task3);
            department2.Tasks.Add(task3);

            // *****************************************************************************************************************************************************

            // створюється список об'єктів типу TaskDepartmentVM і заповнює його екземплярами об'єктів TaskDepartmentVM

            List<TaskDepartmentVM> taskDepartmentVM = new List<TaskDepartmentVM>(); // порожній список


            // Створюються шість об'єктів TaskDepartmentVM і присвоюються значення їх властивостям


            TaskDepartmentVM taskDepartmentVM1 = new TaskDepartmentVM(task1.TName, department1.DName);
            TaskDepartmentVM taskDepartmentVM2 = new TaskDepartmentVM(task1.TName, department3.DName);

            TaskDepartmentVM taskDepartmentVM3 = new TaskDepartmentVM(task2.TName, department2.DName);
            TaskDepartmentVM taskDepartmentVM4 = new TaskDepartmentVM(task2.TName, department3.DName);

            TaskDepartmentVM taskDepartmentVM5 = new TaskDepartmentVM(task3.TName, department1.DName);
            TaskDepartmentVM taskDepartmentVM6 = new TaskDepartmentVM(task3.TName, department2.DName);

            // Екземпляри об'єктів TaskDepartmentVM додаються до списку taskDepartmentVM за допомогою методу Add()

            taskDepartmentVM.Add(taskDepartmentVM1);

            taskDepartmentVM.Add(taskDepartmentVM2);

            taskDepartmentVM.Add(taskDepartmentVM3);

            taskDepartmentVM.Add(taskDepartmentVM4);

            taskDepartmentVM.Add(taskDepartmentVM5);

            taskDepartmentVM.Add(taskDepartmentVM6);

            // *****************************************************************************************************************************************************

            TaskServiceBLL taskServiceBLL = new TaskServiceBLL(dbTask, dbDepartment);

            TaskServicePL taskServicePL = new TaskServicePL(taskServiceBLL);

            TaskServiceMenu taskServiceMenu = new TaskServiceMenu(taskServicePL);

            MainMenu mainMenu = new MainMenu(taskServiceMenu);

            mainMenu.Run();
        }
    }
}
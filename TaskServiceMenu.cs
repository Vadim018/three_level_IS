using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class TaskServiceMenu
    {

        TaskServicePL taskServicePL;

        public TaskServiceMenu(TaskServicePL taskServicePL)
        {
            this.taskServicePL = taskServicePL;
        }

        public void Run()
        {
            bool flag = true;


            /*
            Цей цикл працює наступним чином:

        Спочатку виводяться на екран меню з різними варіантами:

        Опція 1: Вивести всі завдання з відділами, які їх виконують
        Опція 2: Вивести назви всіх завдань для введеної назви відділу
        Опція 3: Вихід
        Користувач вводить число, що відповідає вибраному варіанту меню, за допомогою методу Console.ReadLine() та конвертує його у ціле число за допомогою Convert.ToInt32().

        За допомогою оператора switch, виконується певна дія, залежно від вибраного числа:

        Якщо вибрано опцію 1, викликається метод taskServicePL.GetTasksByDepartmens(), який виводить всі завдання з відділами, які їх виконують.
        Якщо вибрано опцію 2, викликається метод taskServicePL.GetTasksByDepartmentName(), який виводить назви всіх завдань для введеної назви відділу.
        Якщо вибрано опцію 3, змінна flag встановлюється в false, що викликає вихід з циклу і завершення програми.
        Якщо вибране число не входить в межі доступних опцій (1-3), виводиться повідомлення про помилку.
        Цикл повторюється, поки змінна flag дорівнює true, що дозволяє користувачу вибирати нові опції з меню.
             
             
             */
            while (flag)
            {
                Console.WriteLine("1 ~ Вивести всі завдання, де кожне завдання з відділами, які його виконують");
                Console.WriteLine("2 ~ По введеній назві відділу надавати назви всіх завдань цього відділу");
                Console.WriteLine("3 ~ Вихід");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        taskServicePL.GetTasksByDepartmens();
                        break;
                    case 2:
                        taskServicePL.GetTasksByDepartmentName();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("ПОМИЛКА! ВИБЕРІТЬ ОДИН З НАСТУПНИХ ВАРІАНТІВ ( 1 - 3 )");
                        break;
                }
            }
        }
    }
}
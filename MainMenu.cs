using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class MainMenu
    {
        TaskServiceMenu taskServiceMenu;
        public MainMenu(TaskServiceMenu taskServiceMenu)
        {
            this.taskServiceMenu = taskServiceMenu;
        }
        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. МЕНЮ ВІДДІЛІВ");
                Console.WriteLine("2. ВИХІД");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        taskServiceMenu.Run();
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("ПОМИЛКА! ВИБЕРІТЬ 1 АБО 2");
                        break;
                }
            }
        }
    }
}
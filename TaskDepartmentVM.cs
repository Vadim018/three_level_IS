using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class TaskDepartmentVM
    {
        public string TName { get; set; }

        public string DName { get; set; }

        public TaskDepartmentVM(string tName, string dName)
        {
            TName = tName;
            DName = dName;
        }
        public override string ToString()
        {
            return String.Format(TName + " " + DName);
        }
    }
}

/* 

Цей клас містить дві властивості TName і DName, які представляють назви завдання і відділу відповідно.

Конструктор TaskDepartmentVM приймає параметри tName і dName і ініціалізує відповідні властивості.

Метод ToString() визначений для повернення рядкового представлення об'єкту TaskDepartmentVM, яке складається з об'єднання значень властивостей TName і DName.

Цей клас використовується для створення об'єктів, які містять інформацію про завдання та відділи, що їх виконують. 

*/
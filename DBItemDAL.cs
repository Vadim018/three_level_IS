using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM2
{
    internal class DBItemDAL<T> where T : IID
    {
        private int counter = 1;

        public List<T> Items { get; set; } = new List<T>();

        public int Add(T item)
        {
            item.Id = counter++;
            Items.Add(item);

            return item.Id;
        }
    }
}


/*
     Даний клас DBItemDAL<T> є універсальним (generic) класом з обмеженням типу T, яке вимагає, щоб тип T реалізовував інтерфейс IID. Це означає, що тип T 

    повинен мати властивість Id типу int.

    У класі є такі елементи:

    Приватне поле counter, яке слугує для створення унікальних ідентифікаторів для елементів. Воно ініціалізується значенням 1.

    Властивість Items, яка представляє список елементів типу T. Вона ініціалізується новим порожнім списком.

    Метод Add(T item), який додає новий елемент до списку Items. Цей метод отримує об'єкт типу T як параметр item. Він присвоює значення

        Id для item за допомогою змінної counter, потім збільшує counter на 1. Після цього, item додається до списку Items, і метод повертає значення Id для нового елемента.

    Клас DBItemDAL<T> використовується для зберігання та керування об'єктами типу T, де T повинен мати властивість Id.
 
 */
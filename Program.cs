namespace exp2
{
    /// <summary>
    /// Основной класс программы, содержащий метод Main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Исполняемый метод Main
        /// </summary>
        static void Main()
        {
            // пример был взят из задания 2.4.3 для одномерных массивов:
            // "Проверить, что в массиве есть хотя бы один элемент, равный заданному числу. Если такой элемент есть, найти его номер."

            Console.Write("Введите число, которое хотите найти в списке: ");
            int search = int.Parse(Console.ReadLine());

            CustomListElement elem1 = new CustomListElement(14);
            CustomListElement elem2 = new CustomListElement(48);
            CustomListElement elem3 = new CustomListElement(48);
            CustomList testList = new CustomList(elem1);
            testList.AddLast(elem2);
            testList.AddLast(elem3);
            
            int founds = 0;
            
            for (int i = 0; i < testList.GetLength(); i++)
            {
                var elem = testList.GetElementAtIndex(i);

                if (elem.Value == search)
                {
                    Console.WriteLine("Найден элемент под номером {0} с таким же значением.", i);
                    founds++;
                }

            }
            if (founds == 0)
            {
                Console.WriteLine("Значений в списке не найдено.");
            }


        }
    }

    /// <summary>
    /// Элемент списка.
    /// </summary>
    class CustomListElement
    {
        /// <summary>
        /// Значение элемента.
        /// </summary>
        public int Value;

        /// <summary>
        /// Ссылка на следующий элемент
        /// </summary>
        public CustomListElement Next;

        /// <summary>
        /// Создать элемент со значением value
        /// </summary>
        /// <param name="value"></param>
        public CustomListElement(int value)
        {
            Value = value;
        }
    }

    /// <summary>
    /// Создать однонаправленный список
    /// </summary>
    class CustomList
    {
        /// <summary>
        /// "Голова" списка (ссылка на первый элемент в списке)
        /// </summary>
        private CustomListElement head;

        /// <summary>
        /// Создать пустой список.
        /// </summary>
        public CustomList()
        {
            head = null;
        }

        /// <summary>
        /// Создать список с одним элементов внутри.
        /// </summary>
        /// <param name="element">Первый элемент списка.</param>
        public CustomList(CustomListElement element)
        {
            head = element;
        }

        /// <summary>
        /// Метод для добавления элемента в конец списка
        /// </summary>
        /// <param name="value">Значение элемента списка</param>
        public void AddLast(int value)
        {
            CustomListElement newElement = new CustomListElement(value);
            if (head == null)
            {
                head = newElement;  // Если список пуст, новый элемент становится головой
            }
            else
            {
                CustomListElement current = head;
                // Находим последний элемент
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Добавляем новый элемент в конец
                current.Next = newElement;
            }
        }

        /// <summary>
        /// Метод для добавления элемента в конец списка
        /// </summary>
        /// <param name="element">Элемент списка, который необходимо добавить.</param>
        public void AddLast(CustomListElement element)
        {
            CustomListElement newElement = element;
            if (head == null)
            {
                head = newElement;  // Если список пуст, новый элемент становится головой
            }
            else
            {
                CustomListElement current = head;
                // Находим последний элемент
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Добавляем новый элемент в конец
                current.Next = newElement;
            }
        }

        /// <summary>
        /// Получить элемент по заданному индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public CustomListElement GetElementAtIndex(int index)
        {
            CustomListElement current = head;
            int count = 0;

            while (current != null)
            {
                if (count == index)
                    return current;
                count++;
                current = current.Next;
            }

            return null; // Индекс вне диапазона
        }

        /// <summary>
        /// Получить длину списка
        /// </summary>
        public int GetLength()
        {
            CustomListElement current = head;
            int length = 0;

            while (current != null)
            {
                length++;
                current = current.Next;
            }

            return length;
        }

        /// <summary>
        /// Очистить весь список.
        /// </summary>
        public void Clear()
        {
            head = null;
        }
    }
}
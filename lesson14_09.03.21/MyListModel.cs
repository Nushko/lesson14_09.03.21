using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14_09._03._21
{
    class MyList<T>
    {
        // Все элементы лисат хранятся тут
        static T[] List = new T[0];

        // Общее количество элементов в листе
        public int Count { get { return List.Length; } }

        /// <summary>
        /// Добавляет элемент в конец листа
        /// </summary>
        public void Add(T add)
        {
            Array.Resize(ref List, Count + 1);
            List[^1] = add;
        }

        /// <summary>
        /// Добавляет элемент на определённый индекс
        /// </summary>
        public void Insert(int index, T element)
        {
            if (index <= Count)
            {
                Array.Resize(ref List, Count + 1);
                for (int i = Count - 1; i >= index + 1; i--)
                    List[i] = List[i - 1];
                List[index] = element;
            }
        }

        /// <summary>
        /// Находит элемент листа по индексу
        /// </summary>
        /// <returns>В случае если элемент найден, то возвращает его, иначе возвращает default</returns>
        public T Find(int index)
        {
            if (index >= Count)
                return default;

            return List[index];
        }

        /// <summary>
        /// Покаазывает все элементы листа
        /// </summary>
        public void FindAll()
        {
            foreach (var x in List)
                Console.Write(x + " ");
        }
    }
}

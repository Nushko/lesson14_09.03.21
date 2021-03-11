using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14_09._03._21
{
    class MyDictionary<TKey, TValue>
    {
        // Все элементы словаря хранятся тут
        static TKey[] Keys = new TKey[0];
        static TValue[] Values = new TValue[0];
        
        // Общее количество элементов в листе
        public int Count { get { return Keys.Length; } }

        /// <summary>
        /// Добавляет элемент в словарь
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref Keys, Keys.Length + 1);
            Keys[^1] = key;

            Array.Resize(ref Values, Values.Length + 1);
            Values[^1] = value;
        }

        /// <summary>
        /// Находит элемент словаря по ключу
        /// </summary>
        /// <returns>В случае если элемент найден, то возвращает его, иначе возвращает default</returns>
        public TValue FindByKey(TKey key)
        {
            for (int i = 0; i < Keys.Length; i += 1)
                if (key.Equals(Keys[i]))
                    return Values[i];
            
            return default;
        }

        /// <summary>
        /// Показывает все элементы словаря
        /// </summary>
        public void FindAll()
        {
            for (int i = 0; i < Keys.Length; i += 1)
                Console.WriteLine($"Ключ: {Keys[i]},/t Значение: {Values[i]}");
        }
    }
}

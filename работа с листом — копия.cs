using System;
using System.Collections;
using System.Collections.Generic;
namespace работа_с_листом
{
    class MyNewList<T> : IEnumerable<T[]> where T : struct
    {
        public int Znak { get; set; }
        private List<T[]> List1 = new List<T[]>();
        public void Add()
        {
            T[] massiv = new T[] { default(T) };
            ++Znak;
            List1.Add(massiv);
        }
        public void Add(T inValue)
        {
            T[] massiv = new T[] { inValue };
            ++Znak;
            List1.Add(massiv);
        }
        public void Add(T inValue1, T inValue2)
        {
            T[] massiv = new T[] { inValue1, inValue2 };
            ++Znak;
            List1.Add(massiv);
        }
        public void Add(T[] massiv)
        {
            ++Znak;
            List1.Add(massiv);
        }
        public void RemoveAt(int index)
        {
            --Znak;
            List1.RemoveAt(index);
        }
        public IEnumerator<T[]> GetEnumerator()
        {
            return List1.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return List1.GetEnumerator();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyNewList<int> mynewList = new MyNewList<int>();
            mynewList.Add();
            mynewList.Add(5);
            mynewList.Add(15, 30);
            mynewList.Add(new int[] { 10, 20, 30 });
            mynewList.RemoveAt(6);
            Console.WriteLine("Number of Elements" + mynewList.Znak);
            int q = 0;
            foreach(var mynewList1 in mynewList)
            {
                Console.WriteLine("List item"+q++);
            }
            Console.WriteLine();
        }
    }
}
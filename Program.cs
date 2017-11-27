using System;
using System.Text;

    class Stack
    {
        static void Main(string[] args)
        {
            Encoding win = Encoding.GetEncoding("Windows-1251");
            var cars = new StackExample();
            cars.Push("Иван");

            while (!cars.Empty)
            {
                string name = cars.Pop();
                Console.WriteLine(name);
            }
        }
    }


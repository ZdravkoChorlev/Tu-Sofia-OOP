using System;
using System.IO;

class FileCreate
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("Programa.txt"))
        {
            for (int i = 1; i < 1000; i++)
            {
                writer.WriteLine("Ще програмирам по 6 часа на седмица!");
            }
        }

       // using (StreamReader reader = new StreamReader("Programa.txt"))
       // {
        //    Console.WriteLine(reader.ReadToEnd());
       // }
    }
}
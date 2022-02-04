using System;

namespace Massiv3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name =
{
    "",
    
};

            Console.Write("Введите имя:");
            
            string name1 = Console.ReadLine();


            for (int i = name1.Length - 1; i >= 0; i--)
            {
                Console.Write(name1[i]);
            }
            Console.ReadLine();
        }
    }
}

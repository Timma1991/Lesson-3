using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            string[,] students =
{
    { "Иванов" ,"453636" },
    { "Петров" ,"634636" },
    { "Сидоров","3462346" },
    { "Петрова","34634"},
    {"Филиппова","346347"},
    {"Егоров" ,"3463246"},
    { "Козлова","346346"},
};
            
            int heigth = students.GetLength(0);
           
            int width = students.GetLength(1);

            int students1 = 0;
            for (int y = 0; y < heigth; y++)
            {
                string currentValue = students[y,students1];

                for (int i = 0; i < width; i++)
                {
                    Console.Write(students[y,i]);
                }
                Console.WriteLine();
            }
    }
}

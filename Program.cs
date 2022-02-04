using System;

namespace Massiv4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] students =
{
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
    { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
     { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
      { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
       { "X" ,"O","X" ,"O","X" ,"O","X" ,"O","X" ,"O", },
};

            int heigth = students.GetLength(0);

            int width = students.GetLength(1);

            int students1 = 0;
            for (int y = 0; y < heigth; y++)
            {
                string currentValue = students[y, students1];

                for (int i = 0; i < width; i++)
                {
                    Console.Write(students[y, i]);
                }
                Console.WriteLine();
            }
    }
}

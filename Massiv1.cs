using System;

namespace Massiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
                        {
                {123, 456, 111 },
                {1113, 334, 45 },
                {12345, 435, 678 },
                {554, 5643, 2354 },
                        };
            //Высота массива
            int heigth = array.GetLength(0);
            //Ширина массива
            int width = array.GetLength(1);

            //Указатель на текущее положение по X (колонкам)
            int currentX = 1;
            for (int y = 0; y < heigth; y++)
            {
                //Текущее значение из массива по координатам X & Y
                int currentValue = array[y, currentX];

                for (int i = 0; i < currentX; i++)
                {
                    Console.Write("\t");
                }
                Console.WriteLine(currentValue);

                currentX = currentX + 1;
                if (currentX >= width)
                {
                    currentX = 0;
                }
            }
            
            }
           
        }
    }


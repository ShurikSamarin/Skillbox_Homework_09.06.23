// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Life
{
    static void Main()
    {
        // Установите размер сетки
        const int width = 40;
        const int height = 10;

        // Создайте сетку
        bool[,] grid = new bool[width, height];

        // Заполните сетку случайными значениями
        Random random = new Random();
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                grid[x, y] = random.Next(0, 2) == 1;
            }
        }

        // Основной цикл игры
        while (true)
        {
            // Очистите экран
            Console.Clear();
            Console.CursorVisible = false;

            // Выведите сетку
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(grid[x, y] ? "#" : ".");
                }
                Console.WriteLine();
            }

            // Создайте новую сетку, основываясь на старой сетке
            bool[,] newGrid = new bool[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Определите количество соседей текущей клетки
                    int neighbors = 0;
                    for (int xOffset = -1; xOffset <= 1; xOffset++)
                    {
                        for (int yOffset = -1; yOffset <= 1; yOffset++)
                        {
                            // Пропустите проверку самой клетки
                            if (xOffset == 0 && yOffset == 0)
                            {
                                continue;
                            }

                            // Проверьте соседнюю клетку
                            int neighborX = x + xOffset;
                            int neighborY = y + yOffset;

                            // Проверьте граничные условия
                            if (neighborX < 0)
                            {
                                neighborX = width - 1;
                            }
                            else if (neighborX == width)
                            {
                                neighborX = 0;
                            }

                            if (neighborY < 0)
                            {
                                neighborY = height - 1;
                            }
                            else if (neighborY == height)
                            {
                                neighborY = 0;
                            }

                            // Если соседняя клетка жива, добавьте ее к количеству соседей
                            if (grid[neighborX, neighborY])
                            {
                                neighbors++;
                            }
                        }
                    }

                    // Основываясь на количестве соседей, определите, будет ли клетка жива или мертва
                    if (grid[x, y])
                    {
                        if (neighbors < 2 || neighbors > 3)
                        {
                            newGrid[x, y] = false;
                        }
                        else
                        {
                            newGrid[x, y] = true;
                        }
                    }
                    else
                    {
                        if (neighbors == 3)
                        {
                            newGrid[x, y] = true;
                        }
                        else
                        {
                            newGrid[x, y] = false;
                        }
                    }
                }
            }

            // Обновите старую сетку
            grid = newGrid;

            // Подождите перед обновлением экрана
            Console.ReadLine();
        }
    }
}
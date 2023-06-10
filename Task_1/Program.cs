// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input N");
int width = int.Parse(Console.ReadLine());
Console.WriteLine("Input M");
int height = int.Parse(Console.ReadLine());
int[,] array = new int[width, height];
Random random = new Random();
    for (int x = 0; x < width; x++)
    {
        for (int y = 0; y < height; y++)
            {
               array[x, y] = random.Next(10,99);
            }
        }
for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
            {
               Console.Write($"  {array[x, y]}");
            }
              Console.WriteLine();
    }


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input M");
int m = int.Parse(Console.ReadLine());

int[,] array (int width, int height){
    int [,] array = new int [width,height];
    for (int x = 0; x < width; x++)
    {
        for (int y = 0; y < height; y++)
            {
               array[x, y] = new Random().Next(10,49);
               Console.Write($" {array[x, y]}");
            }
            Console.WriteLine();
        }
        return array;
}
void SumArray (int [,] arr1, int [,] arr2){
for (int x= 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
            {
               Console.Write($" {arr1[x, y]+arr2[x,y]}");
            }
              Console.WriteLine();
    }
}
int[,] array1 = array(m, n);
Console.WriteLine();
int[,] array2 = array(m, n);
Console.WriteLine();
SumArray(array1, array2);
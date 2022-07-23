int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + " ");
        }
        Console.WriteLine();
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().NextDouble() + new Random().Next(0, 10);
        }
    }
}
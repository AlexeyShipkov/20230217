/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] CreateNewArray (int m, int n)  //метод создания нового случайного двумерного массива, размер указывает пользователь
{
    double [,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {    
        array[i,j] = Math.Round((new Random().NextDouble()*2-1)*100, 1); // массив положительных и отрицательных чисел от 0 до 100, округленный до 1/10
        }
    }
    return array; 
}

void ShowArray (double [,] array)   //  метод вывода двумерного массива 
{
    for (int i = 0; i < array.GetUpperBound(0)+1; i++) //цикл до номера последнего элeмента в нyлевой размерности +1 (количество строк)
    {
        for (int j =0; j < array.Length/(array.GetUpperBound(0)+1); j++) // количество столбцов вычисляем как длинну массива / количество строк
        {
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("input array size (strings)"); // запрос размера массива
int user_m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input array size (columns)");
int user_n = Convert.ToInt32(Console.ReadLine());

double [,] newArray = CreateNewArray(user_m, user_n); // создание массива
Console.WriteLine($"The random array {user_m}x{user_n} is:");
ShowArray(newArray); // вывод массива

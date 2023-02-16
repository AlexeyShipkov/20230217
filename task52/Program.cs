/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] CreateNewArray (int m, int n)  //метод создания нового случайного двумерного массива, размер указывает пользователь
{
    int [,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {    
        array[i,j] = new Random().Next(0, 10); // массив положительных  чисел от 0 до 9
        }
    }
    return array; 
}

void ShowArray (int [,] array)   //  метод вывода двумерного массива 
{
    for (int i = 0; i < array.GetUpperBound(0)+1; i++) //цикл до номера последнего элемента в нулевой размерности +1 (количество строк)
    {
        for (int j =0; j < array.Length/(array.GetUpperBound(0)+1); j++) // количество столбцов вычисляем как длинну массива / количество строк
        {
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double [] Columns (int [,] array)   //  метод расчета среднего арифметического элементов в каждом столбце
{
    int arrayStrings = array.GetUpperBound(0)+1;  // количество строк
    int arrayColumns = array.Length/(array.GetUpperBound(0)+1); // количество столбцов
    double [] arrayFinal = new double[arrayColumns]; // массив, в который будем выводить результат, размер равен количеству столбцов исходного массива

    for (int j = 0; j < arrayColumns; j++)   // цикл по столбцу
    {
        double sum = 0;      // переменная для суммы значений в столбце
        for (int i =0; i < arrayStrings; i++) // построчно идем в столбце
        {
        sum = sum + array[i,j];  // рассчитываем сумму элементов в столбце
        }
        arrayFinal[j] = Math.Round(sum/arrayStrings,1);  // заполняем итоговый массив, округляем до 1/10
    }
    return arrayFinal;
}

void ShowArray1 (double [] array)   //  метод вывода одномерного  массива с элементами типа double
{
       for (int i =0; i < array.Length; i++)
        {
        Console.Write(array[i] + "; ");
        }
    
}

Console.WriteLine("input array size (strings)"); // запрос размера массива
int user_m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input array size (columns)");
int user_n = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateNewArray(user_m, user_n); // создание массива
Console.WriteLine($"The random array {user_m}x{user_n} is:");
ShowArray(newArray); // вывод массива
Console.WriteLine();  // пустая строка
Console.WriteLine("The average of each column is:");  
ShowArray1(Columns(newArray));


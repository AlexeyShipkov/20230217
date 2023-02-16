/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int [,] CreateNewArray (int m, int n)  //метод создания нового случайного двумерного массива, размер указывает пользователь
{
    int [,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {    
        array[i,j] = new Random().Next(0, 100); // массив положительных  чисел от 0 до 99
        }
    }
    return array; 
}

void ShowArray (int [,] array)   //  метод вывода двумерного массива 
{
    for (int i = 0; i < array.GetUpperBound(0)+1; i++) //цикл до номера последнего элкмента в нолевой размерности +1 (количество строк)
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

Console.WriteLine("input array position (string). starting at 1"); // запрос индекса, откда выводим элемент
int user_x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input array position (column). starting at 1");
int user_y = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateNewArray(user_m, user_n); // создание массива
Console.WriteLine($"The random array {user_m}x{user_n} is:");
ShowArray(newArray); // вывод массива

if(user_x <= user_m && user_y <= user_n) // проверка, что ищем индекс принадлежащий массиву
Console.WriteLine($"On the place {user_x}:{user_y} is element: {newArray[user_x-1,user_y-1]}");  // вывод  элемента
else 
Console.WriteLine("такого числа в массиве нет"); // иначе вывод отсутствия элемента
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.WriteLine("Введите значения (M) и (N) промежутка чисел.");
// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());

// void PrintNums (int startNum, int endNum)
// {
//     Console.Write(startNum + " ");
//     if (startNum >= endNum)
//     {
//         return;
//     }
//     PrintNums (startNum+1, endNum);
// }

// PrintNums(M,N);



// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// Пример: 
// m = 2, n = 3 -> A(m,n) = 29

// Console.WriteLine("Введите значения m и n");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int A (int m, int n)
// {
//     if (m < n || n < 0) {Console.WriteLine("Введите неотрицательные числа.");}
//     if (m == 0) {return n+1; }
//     if (n == 0) { return A(m-1,1);}
//     else {return A(m-1, A(m, n-1));}
// }
// Console.WriteLine("Функция = " + A(m,n));


// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы
// Примеры:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int [m];

void CreateArray (int [] array, int i)
{
    if (i >= array.Length) 
    {
        return;
    }

    array[i] = new Random().Next(1,10);
    Console.Write(array[i] + " ");
    CreateArray(array, i + 1);
}

void ReverseArray (int [] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    ReverseArray(array, index - 1);
}
CreateArray(array, 0);
Console.WriteLine();
ReverseArray(array, array.Length -1);
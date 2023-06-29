// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int endNum = 1;

// System.Console.WriteLine(PrintNumbers(num, endNum));

// string PrintNumbers (int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         return num1.ToString();
//     }

//     return (num1 + " " + PrintNumbers(num1-1, num2));
// }
// ________________________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintAmount(M,N));

// int PrintAmount (int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         Console.WriteLine("нет решения");
//         return 0;
//     }
//     if (num1 == num2)
//     {
//         Console.WriteLine("Введеные числа равны");
//         return num1;
//     }
//     return(num1+ PrintAmount(num1+1, num2));
// }
// ____________________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkrFun(int m, int n)
// {
// if (m == 0) 
// {
//     return n + 1;
// }
// else if (n == 0) 
// {
//     return AkkrFun(m-1, 1);
// }
// else 
// {
//     return AkkrFun(m-1, AkkrFun(m, n-1));
// }
// }
// Console.Write("Результат функции Аккермана: " + AkkrFun(m, n));



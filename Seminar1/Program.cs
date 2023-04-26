// HomeWork 1.

// Task 1. Напишите программу, которая на вход два числа и проверяет, 
// является ли первое число квадратом второго.

// Console.Write("input + first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad2 = num2 * num2;

// if(num1 == quad2)
// {
//     Console.WriteLine("Yes!");
// }
// else
// {
//     Console.WriteLine("No!");
// }

// Task 2. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = -num;

// while(current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }

// Task 3

// 32145 / 10 = 3214
// 32145 / 100 = 321
// 32145 / 1000 = 32
// 32145 / 10000 = 3

// 32145 % 10 = 5
// 32145 % 100 = 45
// 32145 % 1000 = 145
// 32145 % 10000 = 2145

// 72635 - > 26

// 72635 % 10000 = 2635 / 100 = 26

//Задача 2: 
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Clear();
//     int a, b;
    
//     Console.Write("Input the a: ");
//     a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the b: ");
//     b = Convert.ToInt32(Console.ReadLine());
    
// int max = a;

// if (a > max ) max = a;
// if (b > max ) max = b;

// Console.Write("max = ");
// Console.WriteLine(max);


// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


//    Console.Clear();
//     int num1, num2, num3;
    
//     Console.Write("Input the num1: ");
//     num1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the num2: ");
//     num2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the num3: ");
//     num3 = Convert.ToInt32(Console.ReadLine());
 
//   if (num1 > num2)
//     {
//         if (num1 > num3)
//         {
//             Console.Write("num1 самое большое из 3-х");
//         }
//         else
//         {
//             Console.Write("num3 самое большое из 3-х");
//         }
//     }
//     else if (num2 > num3)
//         Console.Write("num2 самое большое из 3-х");
//     else
//         Console.Write("num3 самое большое из 3-х");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Clear();

// Console.Write("input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num;

// while(current <= num)
// {
//    Console.Write(current + " ");
//    current++;
// }

// if (num % 2 == 0) 
// {
//    Console.WriteLine("Yes");
// } 
// else {
//    Console.WriteLine("No");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Clear();
// Console.Write("input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for(int i=1; i<=n; i++)
// {
//     if (i % 2 == 0)
//     Console.Write(i + " ");
// }
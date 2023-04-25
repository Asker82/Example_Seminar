// HomeWork 1.

// Task 1. Напишите программу, которая на вход два числа и проверяет, 
// является ли первое число квадратом второго.

Console.Write("input + first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int mod = Math.Abs(a) % 2;
if (mod == 1) Console.WriteLine("Нечётное");
if (mod == 0) Console.WriteLine("Чётное");

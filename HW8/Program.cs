// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
int i = 1;
int summ = 0;
int mod = 0;
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0) Console.WriteLine("Ошибка. Число не натуральное");
else
{
    while (i <= n)
        {
            mod = i % 2;
            if (mod == 0) summ += i;
            i += 1;
        }
    Console.WriteLine("Сумма чётных чисел до N: " + summ);    
}

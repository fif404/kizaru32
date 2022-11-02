// Скрипников Сергей 17 вариант 2.2
Console.WriteLine("Введите число x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число y:");
double y = double.Parse(Console.ReadLine());
if ((x >= 0 ) && (y <=0))
        Console.WriteLine("данная точка лежит в четвёртой четверти");
else
    Console.WriteLine("данная точка не лежит в четвёртой четверти");
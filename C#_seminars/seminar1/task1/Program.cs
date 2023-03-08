// ввести два числа и проверить что первое является квадратов второго
Console.WriteLine("введите первое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32 (Console.ReadLine());
if (a==b*b) {
    Console.WriteLine("Первое число является квадратом второго");
}
else
Console.WriteLine("Первое число не является квадратом второго");
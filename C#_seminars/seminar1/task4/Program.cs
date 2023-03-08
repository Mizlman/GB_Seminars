// // Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32 (Console.ReadLine());
if (num >99 && num <1000) { 
    int result= num%10;
Console.WriteLine(result);}
else
Console.WriteLine("неккоректный ввод");
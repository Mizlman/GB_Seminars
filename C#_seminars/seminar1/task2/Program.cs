// вывести день недели по заданному числу
Console.WriteLine("введите номер для дня недели от 1 до 7");
int num = Convert.ToInt32 (Console.ReadLine());
switch(num) {
case 1:
    Console.WriteLine("День недели - Понедельник");
    break;
case 2:
    Console.WriteLine("День недели - Вторник");
    break;
case 3:
    Console.WriteLine("День недели - Среда");
    break;
case 4:
    Console.WriteLine("День недели - Четверг");
    break;
case 5:
    Console.WriteLine("День недели - Пятница");
    break;
case 6:
    Console.WriteLine("День недели - Суббота");
    break;
case 7:
    Console.WriteLine("День недели - Воскресенье");
    break;
default:
    Console.WriteLine("Введен неправильный номер");
    break;
}
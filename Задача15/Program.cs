// : Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Random number = new Random();
int a = number.Next(1,11);
switch (a)
{
    case 1:
        Console.WriteLine("понедельник (не выходной)");
        break;
    case 2:
        Console.WriteLine("вторник (не выходной)");
        break;
    case 3:
        Console.WriteLine("среда (не выходной)");
        break;
    case 4:
        Console.WriteLine("четверг (не выходной)");
        break;
    case 5:
        Console.WriteLine("пятница (не выходной, но рядом ;))");
        break;
    case 6:
        Console.WriteLine("суббота (выходной)");
        break;
    case 7:
        Console.WriteLine("воскресение (выходной)");
        break;
    default:
        Console.WriteLine($"{a} (намеренный ввод неверного числа) введите корректный день недели от 1 до 7");
        break;
}
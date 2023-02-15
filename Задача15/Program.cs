// : Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру деня недели");
int a = Convert.ToInt32(Console.ReadLine());

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
        Console.WriteLine("воскресенье (выходной)");
        break;
    default:
        Console.WriteLine("введите корректный день недели от1 до 7");
        break;
}
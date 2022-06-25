// выводим день недели по заданому числу

Console.Write("введите день ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.Write("сегодня понедельник");
}
if (day == 2)
{
    Console.Write("сегодня вторник");
}
if (day == 3)
{
    Console.Write("сегодня среда");
}
if (day == 4)
{
    Console.Write("сегодня четверг");
}
if (day == 5)
{
    Console.Write("сегодня пятница");
}
if (day == 6)
{
    Console.Write("сегодня суббота");
}
if (day == 7)
{
    Console.Write("сегодня воскресенье");
}
else
Console.Write("в неделе только 7 дней");
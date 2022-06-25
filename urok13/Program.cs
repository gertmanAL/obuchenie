//напишите програму которая на вход принимает 2 числа ивыдает какое число большее а какое меньшее
Console.Write("input number ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input number ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

    if(number_2> max)
    Console.Write(" а =" + number_1 + " b =" + number_2 + "->" + " max =" + number_2);
else
     Console.Write(" a = " + number_1 + " b =" + number_2 + "->" + " max =" + number_1);
Console.WriteLine( " самое большое число, ты в школу ходил?");
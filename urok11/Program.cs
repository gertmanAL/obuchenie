// напишите програму которая на вход принимает 2 числа и проверяет является первое числоквадратом второго

Console.Write("input number ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input number ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int g = number_2 * number_2;
if (number_1 == g)

    Console.Write("a = " + number_1 + "b=" + number_2 + "->" + "yes");

else
{
    Console.Write("a = " + number_1 + "b=" + number_2 + "->" + "no");
}

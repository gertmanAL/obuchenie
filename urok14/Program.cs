// программа на вход принимает 3 числа и выдает мах этих чисел
Console.WriteLine("ведите число");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите число");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите число");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if(number_2 > max) max = number_2;
if(number_3 > max) max = number_3;

Console.Write(" максимальное число" + max); 

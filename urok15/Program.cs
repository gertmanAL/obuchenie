// вывод чисел от -Н до Н
Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int number = Convert.ToInt32(Console.ReadLine());
int FN = -number;
while(FN <= number)
{
    if(FN <= number)
    Console.Write(FN + ".");
    FN++;
}  
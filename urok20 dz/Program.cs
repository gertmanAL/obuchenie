//вывод 3числа и цифры
void Div(){
Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int a1 = Convert.ToInt32(Console.ReadLine());
int g =999;
if(a1 > g)
 do 
 {
   a1 = a1/10;
}while(a1 > g);

 
 if (a1 < g)
 {
    int posle2 = a1 % 10;
    Console.WriteLine(a1 + "->" + posle2);
 }


  
if(a1<100)
Console.WriteLine(a1 + "даное число 2-х значное и 3-й цифри в нем нет");
}


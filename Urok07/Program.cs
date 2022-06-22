Console.Write("ведите ваше имя");
string username = Console.ReadLine();

if(username.ToLower() == "зайка")
{
    Console.WriteLine("ура");
}
else
{
    Console.WriteLine("привет ");
    Console.WriteLine(username);
}    
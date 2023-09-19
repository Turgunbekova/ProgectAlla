Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
bool Chto0 = a > b;
bool Chto1 = a == b;
bool Chto2 = a < b;

if(Chto0)
{
    Console.WriteLine("max=a  min=b");
}
else if (Chto1)
{
    Console.WriteLine("a=b");
}
else
{
    Console.WriteLine("max=b  min=a");
}



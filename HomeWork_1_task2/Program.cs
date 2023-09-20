Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2){
 Console.Write($"max = min = {num1}");
 }
 else if (num1 < num2){
 Console.Write($"max = {num2}, min = {num1}");
 }
 else{
 Console.Write($"max = {num1}, min = {num2}");
 }
 Console.WriteLine();

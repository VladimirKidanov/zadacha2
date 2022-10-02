//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.Write ("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine ($"{num1} больше {num2}") ;
}
else
{
    Console.WriteLine ($"{num2} больше {num1}") ;
}
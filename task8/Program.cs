// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int ind = 1;
if (number > 0)
{
    Console.Write("Все четные числа от 1 до " + number + " : ");
    while (ind <= number)
    {
        if (ind % 2 == 0)
        {
            Console.Write(ind + " ");
        }
        ind++;
    }
    Console.WriteLine();
}
else Console.WriteLine("Число отрицательное или равно нулю, попробуйте еще раз");
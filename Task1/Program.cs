// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число: ");

int n1 = Convert.ToInt32(Console.ReadLine());
if (n1 >= 100 && n1 < 1000)
{
    Console.WriteLine($"Вторая цифра числа {n1}: {n1%100/10}");
}
else{Console.WriteLine("Введите число от 100 до 999");}

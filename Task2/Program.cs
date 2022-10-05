// See https://aka.ms/new-console-template for more information

int r = new Random().Next(100, 1000);
Console.WriteLine($"Ваше число: {r}");
Console.WriteLine("Без средней цифры: " + r/100 + "" + r%10);
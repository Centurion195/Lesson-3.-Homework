// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число:");
int number = Math.Abs(int.Parse(Console.ReadLine() ?? "0"));

int res = 0;

while (number!=0) {
    res = number%10+res;
    number = number/10;
}

Console.WriteLine($"Сумма цифр в числе: {res}");
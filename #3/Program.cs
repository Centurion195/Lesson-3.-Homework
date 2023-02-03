// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "0");

int res = 1;

for (int i = 1; i<=number; i++) {
    res = i*res;
}

Console.WriteLine($"Произведение чисел от 1 до {number}: {res}");
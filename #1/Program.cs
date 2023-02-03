// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i<=number; i++) {
    Console.WriteLine($"{i}^3={i*i*i}");
}
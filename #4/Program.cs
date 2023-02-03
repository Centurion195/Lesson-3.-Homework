// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i<=number; i++) {
    if (i%2==0) {
        Console.WriteLine($"{i}^3={i*i*i}");
    }
}
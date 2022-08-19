Console.WriteLine("Введите целочисленное число до 9 знаков");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;

while (b <= a) {
    Console.Write(Math.Pow(b,3));
    b = b+1;
    if (b <= a) {
        Console.Write(",");
    }
}
Console.WriteLine();

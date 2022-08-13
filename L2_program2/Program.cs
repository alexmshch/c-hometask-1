Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
if (a / 10 < 10) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    while (a / b >= 1000) {
        b = b * 10;
    }
}
Console.WriteLine((a/b) - (a/(b*10)*10));


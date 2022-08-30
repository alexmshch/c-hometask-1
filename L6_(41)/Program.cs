Console.WriteLine("Укажите, сколько чисел Вы планируете вводить");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
int max = 0;

void MorethanZero (int c) {
    if(c > 0) {
        max = max + 1;
    }
}

if (a < 1) {
    Console.WriteLine("Хорошего Вам дня, До свидания");
} else {
    while (b <= a) {
        Console.WriteLine("Введите число "+b);
        int c = Convert.ToInt32(Console.ReadLine());
        MorethanZero(c);
        b = b + 1;
    }
}
Console.WriteLine(max);

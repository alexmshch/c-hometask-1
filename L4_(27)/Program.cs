Console.WriteLine("Впишите, пожалуйста, до 9 знаков");

int a = Convert.ToInt32(Console.ReadLine()); // получаем данные
int b = 1; //узнаем количество знаков
int c = 1; // получаем параллельно максимальный делитель
double d = 0; // будет использоваться при определении делителей
int e = 2; // будет использоваться при введении числа, сумма цифр которого кратно 2
while (a/c > 10) {
    c = c * 10;
    b=b+1;
} //выяснили размер
if (b%2 != 0) {
    e = 3; //введеное число, сумма цифр которого не кратна
}
int result = a/c;
Console.WriteLine(result);
result = result + (a%10);
Console.WriteLine(result);
if (b == 3) {
    result = result + (a/10%10);
}
    while (d != ((b-e)/2)) {
        c = c/10;
        d = d+1;
        double delitel1 = Math.Pow(10,d);
        double delitel2 = Math.Pow(10,d+1);
        double delitel3 = c*10;
        result = result + Convert.ToInt32(Math.Floor((a % delitel3 / c)));
        result = result + Convert.ToInt32((Math.Floor(a % delitel2 / delitel1)));
        Console.WriteLine(result);
    }

Console.WriteLine(result);


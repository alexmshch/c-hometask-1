Console.WriteLine("Впишите, пожалуйста, до 9 знаков");

int a = Convert.ToInt32(Console.ReadLine()); // получаем данные
int b = 1; //узнаем количество знаков
int c = 1; // получаем параллельно максимальный делитель
double d = 0; // будет использоваться при определении делителей
int e = 2; // будет использоваться при введении числа, сумма цифр которого кратно 2
int neccesary = 1; // проверка на палиндромность
while (a/c > 10) {
    c = c * 10;
    b=b+1;
} //выяснили размер
if (b%2 != 0) {
    e = 3; //введеное число, сумма цифр которого кратна 3
}

if (a/c == a%10) {
    while (d != ((b-e)/2)) {
        c = c/10;
        d = d+1;
        if (neccesary == 1) {
            double delitel1 = Math.Pow(10,d);
            double delitel2 = Math.Pow(10,d+1);
            int delitel3 = c*10;
            if (a % delitel3 / c != Math.Floor(a % delitel2 / delitel1)) {
                neccesary = 0;
            }
        }
    }
} else {
    neccesary = 0;
}
if (neccesary == 1) {
    Console.WriteLine("Палиндром");
} else {
    Console.WriteLine("Не палиндром");
}


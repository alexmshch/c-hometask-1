Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

void Counter(double k1, double k2, double b1, double b2) {
double delitel1 = k1-k2;
double delitel2 = b2-b1;
double x = delitel2/delitel1;
double y = k1 * x + b1;
Console.WriteLine("("+x+";"+y+")");
}

Counter(k1,k2,b1,b2);

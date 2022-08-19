Console.WriteLine("Введите, используя кнопку Энтер координаты 2 точек");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());


double result = Math.Pow(
    (Math.Pow(x2-x1,2) +
    Math.Pow(y2-y1,2) +
    Math.Pow(z2-z1,2)),
    0.5);
Console.WriteLine(result);

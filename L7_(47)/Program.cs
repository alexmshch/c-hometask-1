Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

double Randomizer() {
    Random rand = new Random();
    double number = rand.NextDouble();
    int num = rand.Next(-100,100);
    number = Math.Round(number*num,2);
    return number;
}

double[,] table = new double[m,n];
Random rand = new Random();
for (int a = 0; a < m; a++) {
    for (int b = 0; b < n; b++) {
        table[a,b] = Randomizer();
        Console.Write(table[a,b]+" ");
    }
    Console.WriteLine("");
}

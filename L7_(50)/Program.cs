Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m,n];

Random rand = new Random();
for (int a = 0; a < m; a++)
{
    for (int b = 0; b < n; b++)
    {
        table[a,b] = rand.Next(1,1000);
        Console.Write(table[a,b]+" ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Введите поисковое значение");
int search = Convert.ToInt32(Console.ReadLine());
if (search <= m*n) {
    double del = (search/n);
    if(search % n == 0) {
        del = del-1;
    }
    Console.WriteLine(del);
    int column = Convert.ToInt32(Math.Floor(del));
    Console.WriteLine(column);
    int line = search-column*n-1;
    Console.WriteLine(line);
    Console.WriteLine(table[column, line]);
} else {
    Console.WriteLine("отсутствует");
}

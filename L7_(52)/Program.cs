Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int[,] table = new int[m,n];
double sum = 0;

Random rand = new Random();

for (int a = 0; a < m; a++)
{
    for (int b = 0; b < n; b++)
    {
        table[a,b] = rand.Next(1,100);
        Console.Write(table[a,b]+" ");
    }
    Console.WriteLine("");
}

Console.Write("Средняя всех столбцов равна: ");
for (int a = 0; a < n; a++)
{
    sum = 0;
    for (int b = 0; b < m; b++)
    {
        sum = sum + table[b,a];
    }
    sum = Math.Round(sum/m,1);
    Console.Write(sum+"; ");
}
Console.WriteLine("");

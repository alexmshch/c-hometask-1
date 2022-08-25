int[] array = new int[10];
Random rnd = new Random();
int a = 0;
int sum = 0;
while (a < array.Length) {
    array[a] = rnd.Next(-100, 100);
    if ((a+1)%2 == 0) {
        sum = sum + array[a];
    }
    Console.Write(array[a]);
    a = a+1;
    if (a < array.Length) {
        Console.Write(",");
    }
}
Console.WriteLine("");
Console.WriteLine("Сумма всех элементов: " + sum);
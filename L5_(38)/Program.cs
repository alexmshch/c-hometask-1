double[] array = new double[5];
Random rnd = new Random();
int a = 0;
double min = 100;
double max = 0;
double sum = 0;
while (a < array.Length) {
    array[a] = rnd.Next(1,99);
    if (array[a] < min) {
        min = array[a];
    }
    if (array[a] > max) {
        max = array[a];
    }
    Console.Write(array[a]);
    a = a+1;
    if (a < array.Length) {
        Console.Write(",");
    }
}
Console.WriteLine("");
sum = min + max;
Console.WriteLine("Сумма минимального и максимального элемента: " + sum);

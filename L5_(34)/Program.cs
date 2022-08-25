int[] array = new int [10];
Random rnd = new Random();
int a = 0;
int b = 0;
while (a < array.Length) {
    array[a] = rnd.Next(100, 999);
    if (array[a] % 2 == 0) {
        b = b+1;
    }
    Console.Write(array[a]);
    a = a+1;
    if (a < array.Length) {
       Console.Write(",");
    }
}
Console.WriteLine("");
Console.WriteLine("Четных элементов: " + b);

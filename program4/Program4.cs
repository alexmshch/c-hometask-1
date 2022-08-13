Console.WriteLine("Впишите цифру");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= N)
{
    if (a % 2 == 0) {
        Console.Write(a);
            if (N - a > 1) {
                Console.Write(",");
                Console.Write(" ");
            }
    }
    a = a+1;
}
Console.WriteLine("  ");
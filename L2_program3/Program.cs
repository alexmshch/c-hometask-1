Console.WriteLine("Введите цифру");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 ^ a == 7) {
    Console.WriteLine("да");
} else if (a >= 1 & a < 6) {
    Console.WriteLine("нет");
} else {
    Console.WriteLine("Не день недели"); 
}

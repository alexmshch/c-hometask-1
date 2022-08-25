//какая интересная и потрясающая задача, отлично, что она была четко и доступно объяснена))00))
//какая задача - такое и решение
Console.WriteLine("Ща буит мясо");
Console.WriteLine("Извините, не сегодня, сегодня только магия");

int a = 0;
int sizeofarray = 7;
int[] array = new int[sizeofarray];
Random rnd = new Random();
while (a < sizeofarray) {
    array[a] = rnd.Next(1, 9);
    Console.WriteLine(array[a]);
    a = a+1;
}
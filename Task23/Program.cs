Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write(n+" ->");
while (i<=n)
{
    Console.Write(" "+ Math.Pow(i, 3));
    i++;
}
Console.WriteLine();

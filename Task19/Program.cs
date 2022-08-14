string value = "";
while (value.Length != 5)
{
    Console.WriteLine("Введите пятизначное число: ");
    value = Console.ReadLine();
}

int [] array = new int[5];
int i = 0;
while (i < 5)
{
    array[i] = Convert.ToInt32(value[i]);
    i++;
}

if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет"); 
}



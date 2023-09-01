// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//методы обработки
//метод запроса данных пользователя
int SetSize(string message=" ")
{
    Console.WriteLine($" {message}: ");
    string size_mass=Console.ReadLine();
    int size=int.Parse(size_mass);
    return size;
}

//метод создания массива
int[] FillArray (int Size)
{
    int[] array=new int[Size];
    Random random =new Random();
    for(int i=0;i<Size;i++)
    {
        int minValue=-999;
        int maxValue=999;
        array[i]=random.Next(minValue,maxValue);

    }
    return array;
}

int SummNechet(int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i++)
    {
        if((i-1)%2!=0)
        {
            sum=sum+array[i];
        }
    }
    return sum;
}

int size=SetSize("Введите размер массива: ");
int[] array=FillArray(size);

Console.WriteLine("Созданный массив:");
Console.WriteLine(string.Join(" ",array));

Console.WriteLine($"Сумма чисел на нечетных позициях:{SummNechet(array)}");


// Программа которая считает сколько чисел больше 0 ввёл ползователь
Console.WriteLine("Введите числа через запятую");
string number = Console.ReadLine();
int[] array = new int[number.Length];
GetArray(number);
PrintArray(array);

void GetArray(string number)
{
    for (int i = 0; i < number.Length; i++)
    {
        array[i] = Convert.ToInt32(number[i].ToString());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }

}

int FindNum(int[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"Колличество чисел больше 0 равно {FindNum(array)}");
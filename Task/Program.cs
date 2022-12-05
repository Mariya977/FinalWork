Console.Clear();
string[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] newArray = CreateArray();
ShowArray(newArray);
Console.WriteLine();

if (newArray.Length <= 3)
{
    Console.WriteLine(newArray);
}
else for (int i = 0; i <= 3; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] strArr = new string[n];

void arr(string[] strArr)
{
    for(int i = 0; i < strArr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        strArr[i] = Console.ReadLine();
    }
}

string[] symbol (string[] strArr)
{
    int m = 0;
    for (int i = 0; i < strArr.Length; i++)
    {
        if (strArr[i].Length <= 3)
        m++;
    }
    string[] rezult = new string[m];
    int j = 0;
    for (int i = 0; i < strArr.Length; i++)
    {
        if (strArr[i].Length <= 3)
        {
            rezult [j] = strArr[i];
            j++;
        }
    }
    return rezult;
}

void printArr (string[] strArr)
{
    Console.Write("[");
    for (int i = 0; i < strArr.Length; i++)
    {
        if (i == strArr.Length - 1)
        {
            Console.Write($"\"{strArr[i]}\"");
            break;
        }
        Console.Write($"\"{strArr[i]}\", ");
    }
    Console.Write("]");
}

arr(strArr);
printArr(symbol(strArr));

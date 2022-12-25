int SizeShortArray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    if (count == 0) count = 1;
    return count;
}

string[] CreateShortArray (string[] array, string[] shortArray)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortArray[s] = array[i];
            s++;
        }
    }
    return shortArray;
}

void ShowArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]"); 
}

string[] text = {"the", "worst", "thing", "you", "can", "do", "is", "nothing"};
int newSize = SizeShortArray (text);
string[] resultArray = new string[newSize];

CreateShortArray (text, resultArray);
ShowArray (resultArray);

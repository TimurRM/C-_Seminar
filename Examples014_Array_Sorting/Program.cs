
int [] arr = {1, 5, 4, 8, 3, 2, 7, 1, 5, 9, 2, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} "); // (array[i] + " ")
    }
Console.WriteLine();
Console.WriteLine();
}

void SortingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SortingArray(arr);

PrintArray(arr);


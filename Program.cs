string[] arr1 = new string [10] {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
string[] arr2 = new string[arr1.Length];

int count = 0;
void Array(string[] arr1, string[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
Array(arr1, arr2);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

PrintArray(arr1);
PrintArray(arr2);
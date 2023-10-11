string[] usserArray = new string[5] { "Hello", "2", "world", ":-)", "123" };
string[] printArray = new string[usserArray.Length];
void SecondArray(string[] usserArray, string[] printArray)
{
    int count = 0;
    for (int i = 0; i < usserArray.Length; i++)
    {
        if (usserArray[i].Length <= 3)
        {
            printArray[count] = usserArray[i];
            count++;
        }
    }
}
void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(usserArray, printArray);
PrintArray(printArray);
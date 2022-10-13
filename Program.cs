
string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length]; // массивы по длинне одинаковые (не оч)???
PrintArray(array1);
SecondArray(array1, array2);
PrintArray(array2);

void SecondArray(string[]array1, string[]array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    if (count==0) 
        {
        Console.WriteLine("Нет элементов");
        }
}
void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
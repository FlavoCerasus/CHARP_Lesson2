//int n = 10;
int[] array = { 1, 3, 4, 5, 7, 9, 12 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {  
        Console.Write($"{array[i]} ");
        i = i++;
    }
    i = i+1;
}
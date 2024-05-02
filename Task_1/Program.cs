int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;

Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

//Console.WriteLine(arr[5]); - при выведнии команды вылезет ошибка, что я вышел за пределы массива

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
// Также, если у нас указан небольшой массив, можно использовать вариант:
int[] arr3 = { 1, 2, 3, 4, 5 };


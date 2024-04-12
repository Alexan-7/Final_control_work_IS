Console.Clear();

string[] firstArray = { "Hello", "7", ":^)", "Moscow", "GeekBrains", "-3", "Yakutia", "1$Ы", "GB" };
string[] resultArray = new string[firstArray.Length];

Console.WriteLine("Имеем массив строк: ");
foreach (var value in firstArray)
    Console.Write($"{value} ");

int size2 = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        resultArray[size2] = firstArray[i];
        size2++;
    }
}

Console.WriteLine("\n\nСтроки размера <= 3 символов: ");
foreach (var value in resultArray)
    Console.Write($"{value} ");

/*
Console.Write("Укажите количество элементов вашего массива строк: ");
int elOfArr = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Теперь вводите элементы массива и жмите Enter после каждого: ");

string[] array1 = new string[elOfArr];
string[] array2 = new string[array1.Length];
for (int i = 0; i < array1.Length; i++)
   array1[i] = Console.ReadLine()!;

Console.WriteLine($"Итак, имеем массив строк: [{string.Join(", ", array1)}]");

int size2 = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[size2] = array1[i];
        size2++;
    }
}

Console.WriteLine("\n\nСтроки размера <= 3 символов в нем: ");
foreach (var value in array2)
   Console.Write($"{value} ");
*/
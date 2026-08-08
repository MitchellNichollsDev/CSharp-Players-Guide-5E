int[] originalArray = new int[5];
int[] copyArray = new int[originalArray.Length];

for (int i = 0; i < originalArray.Length; i++)
{
    Console.WriteLine($"Enter your Number for index {i} of your array: ");
    int arrayNumber = Convert.ToInt32(Console.ReadLine());
    originalArray[i] = arrayNumber;
    Console.WriteLine($"Original Array Index {i}: {originalArray[i]}");
}

for (int j = 0; j < copyArray.Length; j++)
{
    copyArray[j] = originalArray[j];
    Console.WriteLine($"Copy Array Index {j}: {copyArray[j]}");
}

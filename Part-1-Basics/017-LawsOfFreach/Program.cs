//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int currentSmallest = int.MaxValue;
//for (int index = 0; index < array.Length; index++)
//{
//    if (array[index] < currentSmallest)
//        currentSmallest = array[index];
//}
//Console.WriteLine(currentSmallest);



//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int total = 0;
//for (int index = 0; index < total; index++)
//    total += array[index];

//float average = (float)total / array.Length;
//Console.WriteLine(average);


//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int currentSmallest = int.MaxValue;

//foreach (int arrayItem in array)
//{
//    if (arrayItem < currentSmallest)
//        currentSmallest = array[arrayItem];
//}
//Console.WriteLine(currentSmallest);

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
foreach (int arrayIndex in array)
{
    total += arrayIndex;
    Console.WriteLine(total);
}
float average = (float)total / array.Length;
Console.WriteLine(average);
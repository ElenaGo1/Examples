// Упорядочивание массива от минимального к максимальному

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
/*
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{

  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;
      for (int j = i + 1; j < array.Length; j++)
      {
            if (array[j] < array[minPosition]) minPosition = j;

      }


    int temporery = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporery;
  }

}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

// Упорядочивание массива от максимального к минимальному
/*
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{

  for (int i = 0; i < array.Length - 1; i++)
  {
    int maxPosition = i;
      for (int j = i + 1; j < array.Length; j++)
      {
            if (array[j] > array[maxPosition]) maxPosition = j;

      }


    int temporery = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temporery;
  }

}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/
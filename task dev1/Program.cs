int [] myArray = new int [10];


void FillArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();


    int[] newArray = new int[myArray.Length];
    int j = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
      if (myArray[i] % 2 == 0 && myArray[i] > 0)
       {
        newArray [i] = myArray[i];
        j++;
       } 
        if(newArray[i] > 0)
        {
        Console.Write($"{newArray[i]} ");
        }
    }



        



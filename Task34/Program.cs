﻿void InputArray(int[]array)
{
    for (int i=0;i<array.Length;i++)
    array[i]=new Random().Next(100,1000);
}
int ReleaseArray(int []array)
{
  int count = 0;
  for (int i=0;i<array.Length;i++)
   {
    if(array[i]%2==0 )
    count++;
   }
return count;
}

Console.Write("введите количество элементов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
InputArray(array);
Console.WriteLine("["+ String.Join(",", array)+ "]");
Console.WriteLine(ReleaseArray(array));
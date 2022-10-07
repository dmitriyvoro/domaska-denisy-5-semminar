void InputArray(int[]array)
{
    for (int i=0;i<array.Length;i++)
    array[i]=new Random().Next(1,21);
}
int ReleaseArray(int []array)
{
    int difference = 0;
    int max = 0;
    int min = array[0];


  
  for (int i=0;i<array.Length;i++) 
   {
    if (array[i]>max)
    max = array[i];
   
   if (array[i]<min) 
   
    min =array[i] ;
   
    difference = max -min;
   }
return difference;
}
Console.Write("введите количество элементов массива:"    );
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
InputArray(array);
Console.WriteLine("["+ String.Join(",", array)+ "]");
Console.WriteLine(ReleaseArray(array));

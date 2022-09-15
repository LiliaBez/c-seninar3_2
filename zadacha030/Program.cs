// Напишите программу, которая выводит массив 
//из 8 элементов, заполненный нулями и единицами 
//в случайном порядке.

int[] FillArray (int size)
{
   int[] array = new int[size]; 

   for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(0, 2);
   }
   return array;
}

void PrintArray (int[] array){
    Console.WriteLine($"[{string.Join (", ", array)}]");
}

PrintArray(FillArray(8));

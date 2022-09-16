/*Пользователь вводит 8 чисел. 
Поместите их в массив и распечатайте.*/

Console.WriteLine("Введите через запятую восемь чисел: ");

int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

Console.WriteLine($"[{string.Join (", ", array)}]");


// возможно, я не правильно поняла задачу..
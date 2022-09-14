// Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

//int n = number; // чтобы вывести неизмененый number в ответе

Console.WriteLine($"Количество цифр в числе {number}: {FindNumLength(number)}");

int FindNumLength(int number)
{
    int count = 0;
    while (number > 0)  
    { 
	    number = number / 10;   		
        count++;
    }
return count;
}
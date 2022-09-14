// Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 0;
int n = number; // чтобы вывести неизмененый number в ответе

while (n > 0)  
{
	int digit = n % 10; // достать последнюю цифру
	n = n / 10;   		// оставить все, кроме последней цифры
    count++;
}

Console.WriteLine($"Количество цифр в числе {number}: {count}");
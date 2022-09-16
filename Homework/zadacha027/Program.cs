/* Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.*/

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

int num = number;
int sum = 0;
for (int i = 0; num > 0; i++)
    {
        int digit = num % 10; 
	    num = num / 10; 
        sum = sum + digit;
    }

Console.WriteLine($"Сумма цифр в числе {number} равняется {sum}");

// ужас... так долго билась, а такая глупая ошибка оказалась
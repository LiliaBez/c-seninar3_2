// Напишите программу, которая принимает на вход 
//число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {number} равно {FindProductOfNumbers(number)}");



int FindProductOfNumbers(int number)
{
    int mult = 1;
    int count = 1;
    while (count <= number)
    {
        mult = mult * count;
        count++;
    }
    return mult;
}


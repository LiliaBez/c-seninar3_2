/*Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A 
в натуральную степень B.*/

Console.WriteLine("Введите через запятую числа A и B: ");

int[] seriesNums = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
// работает, но что-то очень длинно и не понятно получается
Console.WriteLine($"{seriesNums[0]} в степени {seriesNums[1]} = {Exponentiate(seriesNums)}");


int Exponentiate (int[] seriesNums) {
    int mult = seriesNums[0];
    for (int i = 1; i < seriesNums[1]; i++)
        mult = mult * seriesNums[0];
    return mult;
}




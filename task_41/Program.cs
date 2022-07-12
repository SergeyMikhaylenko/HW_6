//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

 Console.Write("Введите необходимое количество чисел : ");
int M = Convert.ToInt32(Console.ReadLine());
int[] MultipleNumbers = new int[M];
int count = 0;


for (int i = 0; i < M; i++)
{
    Console.Write($"число № {i + 1}: ");
     MultipleNumbers[i] = Convert.ToInt32(Console.ReadLine());
    if (MultipleNumbers[i] > 0)
        count++;
}
Console.WriteLine($"Чисел больше нуля: {count}");
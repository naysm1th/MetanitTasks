// Side-effects can be important. 

using System;

class ExerciseIFp1
{
    static void Main()
    {
        // Запрашиваем у пользователя значение числа

        Console.WriteLine("Введите значение числа");
        int num1 = Convert.ToInt32(Console.ReadLine());


        // Проверяем условие и даем результат

        if (num1 > 5 && num1 < 10) Console.WriteLine("Число больше 5 и меньше 10");
        else Console.WriteLine("Неизвестное число");
        

        Console.ReadKey();
    }
}
// Side-effects can be important. 

using System;

class ExerciseIFp1
{
    static void Main()
    {
        // Запрашиваем у пользователя желаемую операцию

        Console.WriteLine("Введите номер операции: \n1.Сложение\n2.Вычитание\n3.Умножение");// Форматируем по строкам
        Console.WriteLine();
        int operation = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Введите первое число");// Запрашиваем первое число
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Введите второе число");// Запрашиваем второе число
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int action; // Вводим переменную, которая отвечает за производимую операцию

        // Проверяем выбранное действие и проводим его через switch...case

        switch (operation)
        {
            case 1:
                Console.WriteLine("Вы выбрали операцию Сложение");
                action = num1 + num2;
                Console.WriteLine("Сумма выбранных Вами чисел равна {0}", action);
                break;
            case 2:
                Console.WriteLine("Вы выбрали операцию Вычитание");
                action = num1 - num2;
                Console.WriteLine("Разница выбранных Вами чисел равна {0}", action);
                break;
            case 3:
                Console.WriteLine("Вы выбрали операцию Умножение");
                action = num1 * num2;
                Console.WriteLine("Произведение выбранных Вами чисел равно {0}", action);
                break;
            default:
                Console.WriteLine("Операция не определена. Ты пытаешься обмануть меня, кожаный ублюдок");
                break;
        }

      
        

       
        Console.ReadKey();
    }
}
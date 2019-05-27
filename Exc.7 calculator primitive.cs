using System;

class ExerciseIFp1
{
    static void Main()
    {

        
        Console.WriteLine("Наш процент по вкладам составляет 7% ежемесячно.\nВведите желаемую сумму.");// Просим инпут суммы у юзера, форматируем
        
        decimal sum = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Введиите количество месяцев, на которое Вы хотите разместить вклад");// Просим инпут месяцев
       
        int months = Convert.ToInt32(Console.ReadLine());

        // Пишем цикл с for для определения его размера вклада
        for (int i = 0; i < months; i++)
            sum +=sum*0.07M;
        Console.WriteLine("По прошествии {0} месяцев, сумма Вашего вклада составит:\n{1}",months,sum);

        
        }
        
    }

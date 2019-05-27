// Side-effects can be important. 

using System;

class ExerciseIFp1
{
    static void Main()
    {
        // Запрашиваем у пользователя изначальную сумму вклада

        Console.WriteLine("Введите сумму вклада");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();


        // Проверяем размер суммы вклада и в зависимости от него даем начисление процента

        Console.WriteLine("Внимание! В рамках рекламы банк начислил Вам дополнительно 15 денег на счет.");
        Console.WriteLine();
        if (num1 < 100) {num1 += num1 * 0.05 + 15;
            Console.WriteLine("Процент по Вашему вкладу составит 5%"); }
        else if (num1 >= 100 && num1 <= 200){ num1 += num1 * 0.07 + 15;
            Console.WriteLine("Процент по Вашему вкладу составит 7%"); }
        else { num1 += num1 * 0.1 + 15;
            Console.WriteLine("Процент по Вашему вкладу составит 10%");
        }

        Console.WriteLine("Сумма Вашего вклада с начисленными процентами равна {0}", num1);
        

        Console.ReadKey();
    }
}
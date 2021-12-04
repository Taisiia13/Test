using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Test();
        }

        static void Test()
        {
            int a = 0;
            var result = string.Empty;
            Console.WriteLine("Профессор лег спать в 8 часов,а встал в 9 часов.Сколько он поспал?");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
                a++;
            Console.WriteLine("На 2х руках 10 пальцев.Сколько пальцев на 10?");
            int x1 = int.Parse(Console.ReadLine());
            if (x1 == 50)
                a++;
            Console.WriteLine("Сколько цифр в дюжене?");
            int x3 = int.Parse(Console.ReadLine());
            if (x3 == 2)
                a++;
            Console.WriteLine("Сколько нужно сделать запилов,чтобы распилить бревно на 12 частей?");
            int x4 = int.Parse(Console.ReadLine());
            if (x4 == 11)
                a++;
            Console.WriteLine("Врач сделал 3 уколав интервале 30 минут.Сколько времени он затратил?");
            int x5 = int.Parse(Console.ReadLine());
            if (x5 == 30)
                a++;
            Console.WriteLine("Сколько цифр 9 в интервале от 1 до 100");
            int x6 = int.Parse(Console.ReadLine());
            if (x6 == 1)
                a++;
            Console.WriteLine("У пастуха было 30 овец.Все кроме одной разбежались.Сколько овец осталось?");
            int x7 = int.Parse(Console.ReadLine());
            if (x7 == 1)
                a++;
            switch (a)
            {
                case 0:
                case 1:
                case 2:
                    result = "Вам надо отдохнуть";
                    break;
                case 3:
                    result = "Способности ниже среднего";
                    break;
                case 4:
                    result = "Способности средние";
                    break;
                case 5:
                    result = "Нормальный";
                    break;
                case 6:
                    result = "Эрудит";
                    break;
                case 7:
                    result = "Гений";
                    break;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

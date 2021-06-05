using System;

namespace ekzamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели:");

            int numberday = int.Parse(Console.ReadLine());
            switch (numberday)
            {
                case 1:
                    Console.WriteLine("Разработка кода, Разработка кода, Иностранный язык");
                    break;
                case 2:
                    Console.WriteLine("Тестирование ИС, Физкультура, Математическая статистика, Математическая статистика");
                    break;
                case 3:
                    Console.WriteLine("Учебная практика, Учебная практика, Учебная практика, Иностранный язык");
                    break;
                case 4:
                    Console.WriteLine("Тестирование ИС, ОС и среды, ОС и среды");
                    break;
                case 5:
                    Console.WriteLine("Проектирование и дизайн ИС, Проектирование и дизайн ИС, Проектирование и дизайн ИС, Физкультура");
                    break;
                case 6:
                    Console.WriteLine("Информационные технологии, Информационные технологии, Разработка кода");
                    break;
                case 7:
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }
        }

    }
}


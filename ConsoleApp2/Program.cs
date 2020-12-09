using System;


namespace Lesson2
{
    public class Lesson_2
    { 
        static void CountMin()
        {
            Console.WriteLine("Введите 3 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int min = a;
            if (b < min)
                min = b;
            else if (c < min)
                min = c;
            Console.WriteLine($"Наименьшое из трех чисел: {min}");
        }
        static void AmountOfNumerals()
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (a != 0)
            {
                count++;
                a = a / 10;
            }
            Console.WriteLine(count);
        }
        static void CountNumbers()
        {
            int count = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                if (a % 2 != 0 && a > 0)
                {
                    count += a;
                }
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Сумма нечетных положительных равна {count}");
        }
        static bool SignIn(int tryings)
        {
            Console.WriteLine($"Кол-во попыток ввода: {tryings}");
            var correctLogin = "root";
            var correctPassword = "GeekBrains";

            do
            {
                Console.WriteLine("Введите логин");
                var userLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var userPassword = Console.ReadLine();
                if (userLogin == correctLogin && userPassword == correctPassword)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы вошли :)");
                    return true;
                }
                else if (tryings > 0)
                {
                    Console.WriteLine();
                    tryings--;

                    Console.WriteLine("Логин или пароль не правильны, попробуйте еще раз");
                    Console.WriteLine($"Кол-во попыток ввода: {tryings}");
                }
            }
            while (tryings > 0);
            Console.WriteLine();
            Console.WriteLine("Вы исчерпали все попытки");
            return false;
        }
        static void CountBodyMassIndex()
        {
            Console.WriteLine("Ваш вес:");
            float mass = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ваш рост:");
            float height = Convert.ToSingle(Console.ReadLine()) / 100;
            float bodyMassIndex = mass / (height * height);

            Console.WriteLine($"Ваш ИМТ: {bodyMassIndex:f2}");
            int needMass = (int)Math.Abs(mass - (height * height * 22));
            if (bodyMassIndex < 18.5f) Console.WriteLine($"Вам нужно набрать: {needMass} кг");
            else if (bodyMassIndex >= 25) Console.WriteLine($"Вам нужно сбросить: {needMass} кг");
            Console.WriteLine();
        }
        static void Main()
        {
            CountBodyMassIndex();
            SignIn(5);
            CountNumbers();
            AmountOfNumerals();
            CountMin();
        }
    }
}
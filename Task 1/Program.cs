using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static bool isTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static double calculationArea(double a, double b, double c)
        {
            double semiperimeter = (a + b + c) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите три стороны для двух треугольников, а программа покажет, у какого площадь больше.");

            #region Задаём переменные и проверяем на правильность ввода данных
            Console.WriteLine("Введите три стороны первого треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (!isTriangle(a, b, c))
            {
                Console.WriteLine("Стороны {0}, {1}, {2} не образуют треугольник!", a, b, c);
                return;
            }

            Console.WriteLine("Введите три стороны второго треугольника: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());

            if (!isTriangle(d, e, f))
            {
                Console.WriteLine("Стороны {0}, {1}, {2} не образуют треугольник!", d, e, f);
                return;
            }
            #endregion

            double firstTriangle = calculationArea(a, b, c);
            double secondTriangle = calculationArea(d, e, f);

            Console.WriteLine("Площадь первого треугольника: {0:F2}", firstTriangle);
            Console.WriteLine("Площадь второго треугольника: {0:F2}", secondTriangle);

            #region Устанавливаем условие для площадей треугольника
            string answerToTask;
            if (firstTriangle > secondTriangle)
            {
                answerToTask = "Площадь первого треугольника больше, чем второго.";

            }

            else if (secondTriangle > firstTriangle)
            {
                answerToTask = "Площадь второго треугольника больше, чем первого.";
            }

            else
            {
                answerToTask = "Площади треугольников равны.";
            }
            #endregion

            Console.WriteLine(answerToTask);
            Console.Write("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}

# Методы

Задача. Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона: S = √p(p-a)(p-b)(p-c). , где a, b, c – стороны треугольника, p – полупериметр.

Решение:
```
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
```
___
задача. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

Решение:
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void calculationForCube(double a, out double volumeOfACube, out double cubeArea)
        {
            volumeOfACube = Math.Pow(a, 3);
            cubeArea = 6 * Math.Pow(a, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычислит объем и площадь поверхности куба по длине его ребра.");

            #region Задаём переменные и проверяем данные на корректность ввода
            Console.Write("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("Длина ребра должна быть положительным числом.");
                return;
            }

            double volumeOfACube;
            double cubeArea;
            #endregion

            calculationForCube(a, out volumeOfACube, out cubeArea);

            Console.WriteLine("Объем куба: {0:F2}", volumeOfACube);
            Console.WriteLine("Площадь поверхности куба: {0:F2}", cubeArea);

            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}

```

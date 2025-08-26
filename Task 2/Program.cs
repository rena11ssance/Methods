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

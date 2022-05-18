using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTheArea
{
    /// <summary>
    /// Класс для рассчета площадей фигур
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// Вычисление площади круга по заданному радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CalculateAreaCircle(double radius)
        {
            return radius >= 0 ? Math.Round((Math.PI * radius * radius),2) : throw new ArgumentException("Недопустимое значение");
        }

        /// <summary>
        /// Вычисление площади треугольника по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CalculateAreaTriangle(double a, double b, double c)
        {
            if (VerificationTriangle(a, b, c))
            {
                var p = (a + b + c) / 2;
                return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),2);
            }
            else throw new ArgumentException("Недопустимое значение"); 
        }

        /// <summary>
        /// Проверка треугольника на прямоугольность по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool CheckingRightTriangle(double a, double b, double c)
        {
            if (VerificationTriangle(a, b, c))
            {
                if (a * a ==  b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                    return true;
                return false;
            }
            else throw new ArgumentException("Недопустимое значение");
        }
        
        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static bool VerificationTriangle(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < b + a) ? true : false;
        }

    }
}

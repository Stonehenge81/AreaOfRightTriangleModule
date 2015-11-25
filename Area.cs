using System;

namespace AreaOfRightTriangleModule
{
    /*
     . Тестовое задание: 
• Напишите функцию, которая вычисляет площадь прямоугольного треугольника, принимая на вход длину каждой его стороны. Функция станет частью библиотеки поставляемой кампанией внешним клиентам.
• Напишите юнит-тесты на нее. */
    static class Area
    {
        /// <summary>
        /// площадь прямоугольного треугольника по формуле S=(a*b)/2                
        /// </summary>
        /// <param name="cathetus1">катет 1</param>
        /// <param name="cathetus2">катет 2</param>
        /// <returns>площадь</returns>
        public static double CalculteAreaOfRightTriangle(double cathetus1, double cathetus2)
        {
            const string messageError = "Длина катета {0} должна быть больше нуля";
            if (cathetus1 <= 0)
            {
                throw new NotSupportedException(string.Format(messageError, "cathetus1"));
            }
            if (cathetus2 <= 0)
            {
                throw new NotSupportedException(string.Format(messageError, "cathetus2"));
            }
            return (cathetus1 * cathetus2) / 2;
        }
    }
}

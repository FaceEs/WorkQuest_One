using System;

namespace WorkQuest_One
{
    public class GeometyCalcAPI
    {
        /// <summary>
        /// Вычислить площадь круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        public double getSquareOfCircle(double radius)
        {
            if (radius >= 0)
                return Math.PI * (radius * radius);
            else return -1;
        }
        /// <summary>
        /// Вычислить площадь треугольника по 3 сторонам
        /// </summary>
        /// <param name="a">1 сторона</param>
        /// <param name="b">2 сторона</param>
        /// <param name="c">3 сторона</param>
        /// <returns></returns>
        public double getSquareOfTriangle(double a, double b, double c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                double p = getTrianglePerimetr(a, b, c);
                return Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            }else
            {
                return -1;
            }
        }
        /// <summary>
        /// Является ли треуогольник прямоугольным
        /// </summary>
        /// <param name="a">1 сторона</param>
        /// <param name="b">2 сторона</param>
        /// <param name="c">3 сторона</param>
        /// <returns></returns>
        public bool isTriangleIsIsosceles(double a, double b, double c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                if ((a * a + b * b) == c * c)
                {
                    return true;
                }
                else return false;
            }return false;
        }
        private double getTrianglePerimetr(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }
    }
}

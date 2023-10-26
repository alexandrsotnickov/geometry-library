using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS.Geometry.Entities;

namespace AS.Geometry.Utilites
{
    public static class ShapeCalculator 
    {
        /// <summary>
        /// Возвращает площадь треугольника, которая была найдена по трём сторонам.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Значение площади треугольника.</returns>
        public static double GetTriangleAreaOnThreeSides(double a, double b, double c)
        {
            return new Triangle(a, b, c).CalculateArea();
        }
        /// <summary>
        /// Возвращает площадь круга, которая была найдена по его радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Значение площади круга</returns>
        public static double GetCircleArea(double radius)
        {
            return new Circle(radius).CalculateArea();
        }

        /// <summary>
        ///  Возвращает принадлежность треугольника к виду "Прямоугольные треугольники". true - да, false - нет
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsRectangular(double a, double b, double c)
        {
            return new Triangle(a, b, c).IsRectangular;
        }
    }
}

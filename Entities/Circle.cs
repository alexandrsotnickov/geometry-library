using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS.Geometry.Interfaces;

namespace AS.Geometry.Entities
{
    internal class Circle : IShape

    {   /// <summary>
        /// Значение радиуса круга
        /// </summary>

        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Круга с таким радиусом не существует");
            }
            Radius = radius;
        }

        /// <summary>
        /// Возвращает площадь круга, используя радиус из конструктора Circle
        /// </summary>
        /// <returns>Значение площади круга</returns>

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

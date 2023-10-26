using AS.Geometry.Interfaces;

namespace AS.Geometry.Entities
{
    internal class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        /// <summary>
        /// Свойство-принадлежность треугольника к виду "Прямоугольные треугольники". true - да, false - нет
        /// </summary>
        public bool IsRectangular
        {
            get
            {

                double[] sides = { SideA, SideB, SideC };
                Array.Sort(sides);

                return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Ни одна из сторон треугольника не может принимать отрицательное значение.");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует.");
            }
            SideA = a;
            SideB = b;
            SideC = c;
        }
        /// <summary>
        /// Возвращает площадь круга, используя три стороны из конструктора Triangle
        /// </summary>
        /// <returns>Значение площади круга</returns>
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.Geometry.Interfaces
{

    /// <summary>
    /// Интерфейс для работы с площадями геометрических фигур
    /// </summary>
    internal interface IShape
    {
        /// <summary>
        /// Возращает площадь фигуры
        /// </summary>
        /// <returns>Значение площади фигуры</returns>
        double CalculateArea();
    }
}

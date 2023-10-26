
using AS.Geometry.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestGeometry
{
    public class TestTriangleArea
    {
        [Fact]
        public void IsRectangular()
        {
            Assert.True(ShapeCalculator.IsRectangular(3, 4, 5));
            Assert.False(ShapeCalculator.IsRectangular(3, 3, 3));
        }

        [Fact]
        public void IsTriangleAreaCorrect()
        {
            Assert.Equal(6.0, ShapeCalculator.GetTriangleAreaOnThreeSides(3, 4, 5));
            Assert.Equal(3.897114317029974, ShapeCalculator.GetTriangleAreaOnThreeSides(3, 3, 3));
            
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(0, 1, 1));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(1, 0, 1));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(1, 1, 0));

            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(-1, 1, 1));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(1, -1, 1));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(1, 1, -1));

            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(1, 2, 4));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(4, 1, 2));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(2, 4, 1));

            //Assert.Throws<ArgumentException>(() => ShapeCalculator.GetTriangleAreaOnThreeSides(5, 6, 9));
        }

        
    }
}

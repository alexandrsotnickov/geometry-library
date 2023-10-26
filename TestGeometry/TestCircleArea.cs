using AS.Geometry.Utilites;
using Xunit;

namespace TestGeometry
{
    public class TestCircleArea
    {
        [Fact]
        public void IsCircleAreaCorrect()
        {
            
            Assert.Equal(Math.PI, ShapeCalculator.GetCircleArea(1));
            Assert.Equal(Math.PI * 16, ShapeCalculator.GetCircleArea(4));
            //Assert.Equal(-Math.PI, ShapeCalculator.GetCircleArea(-1));
            //Assert.Equal(0, ShapeCalculator.GetCircleArea(0));
        }

        [Fact]
        public void IsRightCircle()
        {
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetCircleArea(0));
            Assert.Throws<ArgumentException>(() => ShapeCalculator.GetCircleArea(-1));
            //Assert.Throws<ArgumentException>(() => ShapeCalculator.GetCircleArea(1));
        }
    }
}
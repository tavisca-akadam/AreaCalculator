using System;
using Xunit;
using AreaCalculator;

namespace AreaCalculatorTestCase
{
    public class UnitTest1
    {
        private IShape shape;
        [Fact]
        public void TestCircleArea()
        {
            //Arrange
            shape = new Circle(10);
            double actualResult, expectedResult;

            //Act
            actualResult = shape.Area();
            expectedResult = 314.0;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestSquareArea()
        {
            //Arrange
            shape = new Square(10);
            double actualResult, expectedResult;

            //Act
            actualResult = shape.Area();
            expectedResult = 100;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestRectangleArea()
        {
            //Arrange
            shape = new Rectangle(10, 20);
            double actualResult, expectedResult;

            //Act
            actualResult = shape.Area();
            expectedResult = 200.0;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestTriangleArea()
        {
            //Arrange
            shape = new Triangle(10, 20);
            double actualResult, expectedResult;

            //Act
            actualResult = shape.Area();
            expectedResult = 100.0;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}

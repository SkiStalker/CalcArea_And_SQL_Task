using TestTask;
namespace TestTaskUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircleArea1()
        {
            Assert.Equal(Math.PI * 1 * 1, AreaCalculator.CalcCircleArea(1));
        }

        [Fact]
        public void TestCircleArea2()
        {
            Assert.Equal(Math.PI * 4, AreaCalculator.CalcCircleArea(2));
        }

        [Fact]
        public void TestCircleArea3()
        {
            Assert.Equal(Math.PI * 9, AreaCalculator.CalcCircleArea(3));
        }

        [Fact]
        public void TestTriangleArea1()
        {
            Assert.Equal(6, AreaCalculator.CalcTriangleArea(3, 4, 5));
        }

        [Fact]
        public void TestTriangleArea2()
        {
            Assert.Equal(12, AreaCalculator.CalcTriangleArea(5, 6, 5));
        }

        [Fact]
        public void TestTriangleArea3()
        {
            Assert.Equal(24, AreaCalculator.CalcTriangleArea(10, 6, 8));
        }

        [Fact]
        public void TestRightTriangle1()
        {
            Assert.True(AreaCalculator.IsRightTriangle(29, 20, 21));
        }

        [Fact]
        public void TestRightTriangle2()
        {
            Assert.True(AreaCalculator.IsRightTriangle(3, 4, 5));
        }

        [Fact]
        public void TestRightTriangle3()
        {
            Assert.False(AreaCalculator.IsRightTriangle(22, 20, 21));
        }

        [Fact]
        public void TestArea1()
        {
            Assert.Equal(24, AreaCalculator.CalcArea(10, 6, 8));
        }

        [Fact]
        public void TestArea2()
        {
            Assert.Equal(Math.PI*9, AreaCalculator.CalcArea(3));
        }

        [Fact]
        public void TestArea3()
        {
            Assert.Throws<ArgumentException>(()=> { AreaCalculator.CalcArea(10, 6); });
        }
    }
}
namespace TestProject.Test
{
    public class CalculatorTests
    {
        private readonly Calculator _sut = new();

        [Fact]
        public void Add_Should_ReturnSum()
        {
            var result = _sut.Add(1, 1);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_Should_ReturnDivision()
        {
            var result = _sut.Divide(1, 1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Divide_Should_ReturnDivision2()
        {
            var result = _sut.Divide(0, 2);
            Assert.Equal(0, result);
        }
    }
}
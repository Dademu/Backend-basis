using CalculatorLibrary;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorService
    {

        private CalculatorService _calculatorService;

        public voidCalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var result = _calculatorService.Add(5.0m, 3.0m);
            Assert.Equal(8.0m, result);
        }

        // Similar tests for other operations (subtract, multiply, divide, modulo)...
    }
}


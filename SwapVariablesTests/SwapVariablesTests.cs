using Newtonsoft.Json.Linq;
using SwapVariables;
namespace SwapVariablesTests
{
    public class SwapVariablesTests
    {
        [Theory]
        [InlineData(7, 3, "3, 7")]
        [InlineData(21, 19, "19, 21")]
        [InlineData(52, 35, "35, 52")]
        public void SwapVariables_WithSwappingIfFirstIsGrater_ShouldSwapVariables(int a, int b, string expected)
        {
            string result = VariablesSwapper.SwapVariables(a, b);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(34, 224, "224, 34")]
        [InlineData(21, 59, "59, 21")]
        [InlineData(3, 35, "35, 3")]
        public void SwapVariables_WithSwappingIfSecondIsGrater_ShouldThrowExeption(int a, int b, string expected)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => VariablesSwapper.SwapVariables(a, b, expected));
        }
    }
}
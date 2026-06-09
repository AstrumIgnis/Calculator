using Xunit;
using CalcCore = Calculator.Core;

namespace CalcTests;

/// <summary>
/// Unit tests for the Calculator class.
/// Tests core arithmetic operations and state management.
/// </summary>
public class CalculatorTests
{
    /// <summary>
    /// Tests addition with positive numbers.
    /// </summary>
    [Fact]
    public void Add_WithPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Add(5, 3);

        // Assert
        Assert.Equal(8, result);
    }

    /// <summary>
    /// Tests addition with mixed positive and negative numbers.
    /// </summary>
    [Fact]
    public void Add_WithMixedSigns_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Add(10, -4);

        // Assert
        Assert.Equal(6, result);
    }

    /// <summary>
    /// Tests subtraction with positive numbers.
    /// </summary>
    [Fact]
    public void Subtract_WithPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Subtract(10, 3);

        // Assert
        Assert.Equal(7, result);
    }

    /// <summary>
    /// Tests subtraction resulting in a negative number.
    /// </summary>
    [Fact]
    public void Subtract_WithSmallMinuend_ReturnsNegativeResult()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Subtract(3, 10);

        // Assert
        Assert.Equal(-7, result);
    }

    /// <summary>
    /// Tests multiplication with positive numbers.
    /// </summary>
    [Fact]
    public void Multiply_WithPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Multiply(4, 5);

        // Assert
        Assert.Equal(20, result);
    }

    /// <summary>
    /// Tests multiplication by zero.
    /// </summary>
    [Fact]
    public void Multiply_WithZero_ReturnsZero()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Multiply(100, 0);

        // Assert
        Assert.Equal(0, result);
    }

    /// <summary>
    /// Tests division with positive numbers.
    /// </summary>
    [Fact]
    public void Divide_WithPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Divide(20, 4);

        // Assert
        Assert.Equal(5, result);
    }

    /// <summary>
    /// Tests division with decimal result.
    /// </summary>
    [Fact]
    public void Divide_ResultingInDecimal_ReturnsAccurateResult()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act
        var result = calculator.Divide(10, 3);

        // Assert
        Assert.Equal(10.0 / 3, result, precision: 10);
    }

    /// <summary>
    /// Tests that dividing by zero throws an exception.
    /// </summary>
    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
    }

    /// <summary>
    /// Tests that the Result property is updated after each operation.
    /// </summary>
    [Fact]
    public void Result_IsUpdatedAfterEachOperation()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();

        // Act & Assert
        calculator.Add(5, 3);
        Assert.Equal(8, calculator.Result);

        calculator.Multiply(2, 4);
        Assert.Equal(8, calculator.Result);

        calculator.Subtract(10, 2);
        Assert.Equal(8, calculator.Result);
    }

    /// <summary>
    /// Tests that Reset clears the Result property to zero.
    /// </summary>
    [Fact]
    public void Reset_ClearsResultToZero()
    {
        // Arrange
        var calculator = new CalcCore.Calculator();
        calculator.Add(50, 25);
        Assert.Equal(75, calculator.Result);

        // Act
        calculator.Reset();

        // Assert
        Assert.Equal(0, calculator.Result);
    }
}

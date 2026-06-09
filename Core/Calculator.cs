namespace Calculator.Core;

/// <summary>
/// Provides basic arithmetic operations for calculator functionality.
/// Supports addition, subtraction, multiplication, and division.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Gets the most recent computed result.
    /// </summary>
    public double Result { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Calculator"/> class.
    /// </summary>
    public Calculator()
    {
        Result = 0;
    }

    /// <summary>
    /// Adds two numbers and returns the result.
    /// </summary>
    /// <param name="a">The first operand.</param>
    /// <param name="b">The second operand.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public double Add(double a, double b)
    {
        Result = a + b;
        return Result;
    }

    /// <summary>
    /// Subtracts the second number from the first and returns the result.
    /// </summary>
    /// <param name="a">The minuend (number to subtract from).</param>
    /// <param name="b">The subtrahend (number to subtract).</param>
    /// <returns>The difference of <paramref name="a"/> minus <paramref name="b"/>.</returns>
    public double Subtract(double a, double b)
    {
        Result = a - b;
        return Result;
    }

    /// <summary>
    /// Multiplies two numbers and returns the result.
    /// </summary>
    /// <param name="a">The first factor.</param>
    /// <param name="b">The second factor.</param>
    /// <returns>The product of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public double Multiply(double a, double b)
    {
        Result = a * b;
        return Result;
    }

    /// <summary>
    /// Divides the first number by the second and returns the result.
    /// </summary>
    /// <param name="a">The dividend (numerator).</param>
    /// <param name="b">The divisor (denominator).</param>
    /// <returns>The quotient of <paramref name="a"/> divided by <paramref name="b"/>.</returns>
    /// <exception cref="DivideByZeroException">Thrown when <paramref name="b"/> is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        Result = a / b;
        return Result;
    }

    /// <summary>
    /// Resets the calculator state, clearing the result.
    /// </summary>
    public void Reset()
    {
        Result = 0;
    }
}

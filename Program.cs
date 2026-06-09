using Calculator.Core;
using Calc = Calculator.Core.Calculator;

var calculator = new Calc();

PrintHelp();
Console.WriteLine();

while (true)
{
    Console.Write("> ");
    var input = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(input))
        continue;

    switch (input.ToLower())
    {
        case "exit":
        case "quit":
            return;

        case "reset":
            calculator.Reset();
            Console.WriteLine("Calculator reset.");
            break;

        case "history":
            PrintHistory(calculator);
            break;

        case "help":
            PrintHelp();
            break;

        default:
            Evaluate(calculator, input);
            break;
    }
}

static void Evaluate(Calc calculator, string input)
{
    var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (parts.Length != 3)
    {
        Console.WriteLine("Invalid format. Expected: <number> <operator> <number>");
        return;
    }

    if (!double.TryParse(parts[0], out double a) || !double.TryParse(parts[2], out double b))
    {
        Console.WriteLine("Invalid numbers. Please enter valid numeric values.");
        return;
    }

    try
    {
        double result = parts[1] switch
        {
            "+" => calculator.Add(a, b),
            "-" => calculator.Subtract(a, b),
            "*" => calculator.Multiply(a, b),
            "/" => calculator.Divide(a, b),
            _ => throw new InvalidOperationException($"Unknown operator '{parts[1]}'. Use +, -, *, /")
        };

        Console.WriteLine($"= {result}");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}

static void PrintHistory(Calc calculator)
{
    if (calculator.History.Count == 0)
    {
        Console.WriteLine("No history yet.");
        return;
    }

    for (int i = 0; i < calculator.History.Count; i++)
    {
        var entry = calculator.History[i];
        Console.WriteLine($"  {i + 1,3}. {entry.A} {OpSymbol(entry.Op)} {entry.B} = {entry.Result}");
    }
}

static string OpSymbol(Operation op) => op switch
{
    Operation.Add      => "+",
    Operation.Subtract => "-",
    Operation.Multiply => "*",
    Operation.Divide   => "/",
    _                  => "?"
};

static void PrintHelp()
{
    Console.WriteLine("Calculator REPL");
    Console.WriteLine("  <number> <op> <number>   e.g. 5 + 3, 10 / 2, 3.5 * 4");
    Console.WriteLine("  history                  show past operations");
    Console.WriteLine("  reset                    clear result and history");
    Console.WriteLine("  exit                     quit");
}

namespace Calculator.Core;

public record HistoryEntry(double A, Operation Op, double B, double Result, DateTime Timestamp);

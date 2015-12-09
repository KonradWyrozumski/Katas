using System;

public class Numbers
{
    public static double TwoDecimalPlaces(double number)
    {
        return TruncateDecimal(number, 2);
    }

    private static double TruncateDecimal(double number, int precision)
    {
        var stepper = Math.Pow(10, precision);
        var truncatedStepped = Math.Truncate(number*stepper);
        return truncatedStepped/stepper;
    }
}
using tyuiu.cources.programming.interfaces.Sprint1;
using System;
namespace tyuiu.SavtsovNE.Sprint1.Task4.V13.Lib;

public class DataService : ISprint1Task4V13
{
    public double Calculate(double x, double y)
    {
        double result = Math.Cos(Math.PI / x) / (3 * Math.Exp(x) + y);

        result = Math.Round(result, 3);

        return result;
    }
}

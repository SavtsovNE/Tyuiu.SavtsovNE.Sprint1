using tyuiu.cources.programming.interfaces.Sprint1;

namespace tyuiu.SavtsovNE.Sprint1.Task0.V12.Lib
{
    public class DataService : ISprint1Task0V22
    {
        public double Calculate(double x, double y)
        {
            return (5 + x) / (y * x); 

            //подсчитываем выражения 

        }

        public double Calculate()
        {
            throw new NotImplementedException();
        }
    }

}


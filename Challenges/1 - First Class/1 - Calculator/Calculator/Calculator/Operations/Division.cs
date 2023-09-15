namespace Calculator.Operations
{
    public class Division
    {
        public double Div(double num1, double num2)
        {
            if(num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return 0;
                            }
        }
    }
}

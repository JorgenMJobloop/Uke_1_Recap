public class TestMethods : ITestMethods
{
    public void SayHello()
    {
        Console.WriteLine("Hello There!");
    }

    public double SumSomeNumbers(double a, double b)
    {
        return a + b;
    }

}
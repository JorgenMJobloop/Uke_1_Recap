public class TestAnotherMethod : ITestMethods
{
    public void SayHello()
    {
        Console.WriteLine("Hellooooo");
    }

    public double SumSomeNumbers(double a, double b)
    {
        return a * b;
    }
}
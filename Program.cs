namespace Uke_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person person = new Person();
        person.Name = "John Doe";
        person.Age = 30;
        person.Hobby = "coding";

        List<Person> someGenericTypeObject = new List<Person>();
        someGenericTypeObject.Add(person);

        foreach (var people in someGenericTypeObject)
        {
            Console.WriteLine($"{people.Name} {person.Age} {person.Hobby}");
        }

        string actualNumber = "10";
        int actuallyANumber = Convert.ToInt32(actualNumber);
        Console.WriteLine(actuallyANumber.GetType());
        Console.WriteLine(Convert.ToInt32("1"));


        TestMethods testMethods = new TestMethods();
        TestAnotherMethod testAnotherMethod = new TestAnotherMethod();

        testMethods.SayHello();
        testAnotherMethod.SayHello();


        Console.WriteLine(testMethods.SumSomeNumbers(5, 5)); // 10
        Console.WriteLine(testAnotherMethod.SumSomeNumbers(5, 5)); // 25


        Scopes.Message = "Hello";
        Console.WriteLine(Scopes.Message);

        Scopes.SomeInt = 10;
        Console.WriteLine(Scopes.SomeInt + 50);

        Scopes.MySecretMessage();
    }
}

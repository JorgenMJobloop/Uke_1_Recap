public static class Scopes
{
    public static string? Message;

    public static int SomeInt;

    private static string? SecretMessage;

    readonly static string TheOtherSecret = "The other super secret! Woow";


    public static void MySecretMessage()
    {
        SecretMessage = "Wow, such secrets";
        Console.WriteLine(SecretMessage);
        Console.WriteLine(TheOtherSecret);
    }
}

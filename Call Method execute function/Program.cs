class Program
{
    static void Main(string[] args)
    {
        Class1 c = new Class1();

        //call method 1
        Console.WriteLine("Call :" +c.RunTheMethod(c.Method1));

        //call method 2
        Console.WriteLine("Call :" + c.RunTheMethod(c.Method2));
    }
}
public class Class1
{
    public string Method1(string input)
    {
        //... do something
        return "Method1";
    }

    public string Method2(string input)
    {
        //... do something different
        return "Method2";
    }

    public string RunTheMethod(Func<string, string> myMethodName)
    {
        //... do stuff
        string res = myMethodName("My String");
        //... do more stuff
        return res;
    }

}



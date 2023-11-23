using System.Reflection;

public class Example
{
    public static void Main()
    {
        // Get the type of the MyClass
        Type myClassType = typeof(MyClass);

        // Get private instance fields using BindingFlags
        BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
        FieldInfo[] fieldInfos = myClassType.GetFields(flags);

        Console.WriteLine("Private Instance Fields:");
        foreach (var fieldInfo in fieldInfos)
        {
            Console.WriteLine($" - {fieldInfo.Name}");
        }

        // Get private instance methods using BindingFlags
        MethodInfo[] methodInfos = myClassType.GetMethods(flags);

        Console.WriteLine("\nPrivate Instance Methods:");
        foreach (var methodInfo in methodInfos)
        {
            Console.WriteLine($" - {methodInfo.Name}");
        }

        // Get private instance properties using BindingFlags
        PropertyInfo[] propertyInfos = myClassType.GetProperties(flags);

        Console.WriteLine("\nPrivate Instance Properties:");
        foreach (var propertyInfo in propertyInfos)
        {
            Console.WriteLine($" - {propertyInfo.Name}");
        }
    }
}

public class MyClass
{
    private int _privateField;
    private string PrivateProperty { get; set; }

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }
}

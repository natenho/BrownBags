class Calculator
{
    public int Sum(int a, int b);
    public int Subtract(int a, int b);
    public string Multiply(int a, int b);
    public int Divide(int a, int b);
}


class Program
{
    public void Main()
    {
        Console.WriteLine(int.Parse("70"));
        Console.WriteLine(int.Parse("070")); // 56???
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        double one = double.Parse(Console.ReadLine());
        double two = double.Parse(Console.ReadLine());
        double three = double.Parse(Console.ReadLine());
        double D = Math.Pow(two, 2) - 4 * one * three;
        double x1 = (-two - Math.Sqrt(D)) / (2 * one);
        double x2 = (-two + Math.Sqrt(D)) / (2 * one);
        Console.WriteLine("х1 = {0}, х2 = {1}", x1, x2);
    }
}
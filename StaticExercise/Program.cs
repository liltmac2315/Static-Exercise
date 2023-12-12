namespace StaticExercise
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"celsius {celsius}");
        }
    }
}

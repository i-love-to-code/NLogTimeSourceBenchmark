namespace SamNoble.Demo.NLogTimeSourceBenchmark
{
    using BenchmarkDotNet.Running;

    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<TimeSourceBenchmark>();
        }
    }
}

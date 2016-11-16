namespace SamNoble.Demo.NLogTimeSourceBenchmark
{
    using BenchmarkDotNet.Attributes;
    using NLog.Time;
    using System;

    public class TimeSourceBenchmark
    {
        private readonly TimeSource fastLocalTimeSource;
        private readonly TimeSource fastUtcTimeSource;
        private readonly TimeSource accurateLocalTimeSource;
        private readonly TimeSource accurateUtcTimeSource;

        public TimeSourceBenchmark()
        {
            this.fastLocalTimeSource = new FastLocalTimeSource();
            this.fastUtcTimeSource = new FastUtcTimeSource();
            this.accurateLocalTimeSource = new AccurateLocalTimeSource();
            this.accurateUtcTimeSource = new AccurateUtcTimeSource();
        }

        [Benchmark]
        public DateTime FastLocal()
        {
            return fastLocalTimeSource.Time;
        }

        [Benchmark]
        public DateTime FastUtc()
        {
            return fastUtcTimeSource.Time;
        }

        [Benchmark]
        public DateTime AccurateLocal()
        {
            return accurateLocalTimeSource.Time;
        }

        [Benchmark]
        public DateTime AccurateUtc()
        {
            return accurateUtcTimeSource.Time;
        }
    }
}
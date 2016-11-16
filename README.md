# NLog TimeSource Benchmark

Uses the BenchmarkRunner library to generate benchmark data for NLog's various TimeSource providers. Created against .Net 4.5.2 and makes use of this [Gist](https://gist.github.com/vcaraulean/6a0e3201ea7889e06bd35391bba0d521).

Here's the output from my Windows VM, YMMV.

``` ini
BenchmarkDotNet=v0.10.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4770HQ CPU 2.20GHz, ProcessorCount=2
Frequency=10000000 Hz, Resolution=100.0000 ns, Timer=UNKNOWN
Host Runtime=Clr 4.0.30319.42000, Arch=64-bit RELEASE [RyuJIT]
GC=Concurrent Workstation
JitModules=clrjit-v4.6.1590.0
Job Runtime(s):
	Clr 4.0.30319.42000, Arch=64-bit RELEASE [RyuJIT]

```
        Method |        Mean |    StdErr |    StdDev |      Median |
-------------- |------------ |---------- |---------- |------------ |
     FastLocal |   2.9914 ns | 0.0344 ns | 0.1333 ns |   3.0056 ns |
       FastUtc |   3.2813 ns | 0.0218 ns | 0.0843 ns |   3.2954 ns |
 AccurateLocal | 278.5057 ns | 0.8608 ns | 3.3337 ns | 278.4796 ns |
   AccurateUtc |   5.2378 ns | 0.0392 ns | 0.1517 ns |   5.1960 ns |

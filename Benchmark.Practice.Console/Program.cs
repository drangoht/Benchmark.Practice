using BenchmarkDotNet.Running;
using Benchmark.Practice.Core;

var summary = BenchmarkRunner.Run<StringUtilityHelperBenchmark>();

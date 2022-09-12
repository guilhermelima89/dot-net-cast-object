# .NET 7 CAST OBJECTS BENCHMARK

## commands

- dotnet new console -n Casting
- dotnet add package BenchmarkDotNet --version 0.13.2
- dotnet run --configuration Release
- dotnet run --c Release

## Program.cs

```csharp

BenchmarkRunner.Run<Benchmarks>();

```

## Benchmarks.cs

```ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]     : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2


```

| Method    |      Mean |     Error |    StdDev | Allocated |
| --------- | --------: | --------: | --------: | --------: |
| HardCast  | 0.2486 ns | 0.0148 ns | 0.0139 ns |         - |
| SafeCast  | 0.9929 ns | 0.0160 ns | 0.0149 ns |         - |
| MatchCast | 0.6866 ns | 0.0079 ns | 0.0066 ns |         - |

## BenchmarksList.cs

```ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
AMD Ryzen 7 3800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]     : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX2


```

| Method          |      Mean |     Error |    StdDev | Allocated |
| --------------- | --------: | --------: | --------: | --------: |
| OfType          | 20.647 μs | 0.3678 μs | 0.3440 μs |   16.3 KB |
| Cast_As         | 21.810 μs | 0.1397 μs | 0.1166 μs |  16.34 KB |
| Cast_Is         | 22.468 μs | 0.3144 μs | 0.2941 μs |  16.34 KB |
| HardCast_As     |  8.544 μs | 0.1646 μs | 0.2307 μs |  16.36 KB |
| HardCast_Is     |  8.322 μs | 0.1189 μs | 0.1054 μs |  16.36 KB |
| HardCast_TypeOf |  7.629 μs | 0.0776 μs | 0.0688 μs |  16.36 KB |

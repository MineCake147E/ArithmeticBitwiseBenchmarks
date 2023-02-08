``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.200-preview.22628.1
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|                                  Method | LoopCount | left |      right |      Mean |    Error |   StdDev | Code Size |
|---------------------------------------- |---------- |----- |----------- |----------:|---------:|---------:|----------:|
|        **SingleSingleMultiplyBitConverter** |     **65536** |    **3** |          **1** |  **90.26 μs** | **0.592 μs** | **0.525 μs** |      **44 B** |
|                SingleSingleMultiplySse2 |     65536 |    3 |          1 |  99.84 μs | 0.639 μs | 0.598 μs |      27 B |
|           SingleSingleMultiplyVector128 |     65536 |    3 |          1 | 190.38 μs | 1.011 μs | 0.946 μs |      28 B |
| **SingleVariableInt32MultiplyBitConverter** |     **65536** |    **3** | **1065353216** |  **89.88 μs** | **0.289 μs** | **0.270 μs** |      **35 B** |
|         SingleVariableInt32MultiplySse2 |     65536 |    3 | 1065353216 |  89.85 μs | 0.481 μs | 0.450 μs |      32 B |
|    SingleVariableInt32MultiplyVector128 |     65536 |    3 | 1065353216 | 180.08 μs | 0.566 μs | 0.501 μs |      33 B |
|    **SingleConstInt32MultiplyBitConverter** |     **65536** |    **3** |          **?** |  **89.90 μs** | **0.374 μs** | **0.331 μs** |      **41 B** |
|            SingleConstInt32MultiplySse2 |     65536 |    3 |          ? |  90.09 μs | 0.508 μs | 0.424 μs |      35 B |
|       SingleConstInt32MultiplyVector128 |     65536 |    3 |          ? | 180.25 μs | 1.081 μs | 0.958 μs |      36 B |

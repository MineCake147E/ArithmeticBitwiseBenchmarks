``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.200-preview.22628.1
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|                                Method | LoopCount |                left |               right | value |     Mean |    Error |   StdDev | Code Size |
|-------------------------------------- |---------- |-------------------- |-------------------- |------ |---------:|---------:|---------:|----------:|
|    **DoubleConstInt64AndNotBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **53.59 μs** | **0.157 μs** | **0.131 μs** |      **52 B** |
|       DoubleConstInt64AndNotVector128 |     65536 |                   3 |                   ? |     ? | 18.22 μs | 0.106 μs | 0.094 μs |      35 B |
|        **DoubleDoubleAndNotBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **53.52 μs** | **0.094 μs** | **0.084 μs** |      **47 B** |
|           DoubleDoubleAndNotVector128 |     65536 |                   3 |                   1 |     ? | 22.62 μs | 0.446 μs | 1.034 μs |      27 B |
| **DoubleVariableInt64AndNotBitConverter** |     **65536** |                   **3** | **4607182418800017408** |     **?** | **53.44 μs** | **0.145 μs** | **0.136 μs** |      **42 B** |
|    DoubleVariableInt64AndNotVector128 |     65536 |                   3 | 4607182418800017408 |     ? | 18.29 μs | 0.150 μs | 0.140 μs |      32 B |
| **VariableInt64DoubleAndNotBitConverter** |     **65536** | **4607182418800017408** |                   **1** |     **?** | **53.46 μs** | **0.207 μs** | **0.194 μs** |      **40 B** |
|    VariableInt64DoubleAndNotVector128 |     65536 | 4607182418800017408 |                   1 |     ? | 18.16 μs | 0.082 μs | 0.073 μs |      32 B |
|           **DoubleDecrementBitConverter** |     **65536** |                   **?** |                   **?** |     **3** | **53.45 μs** | **0.167 μs** | **0.148 μs** |      **36 B** |
|              DoubleDecrementVector128 |     65536 |                   ? |                   ? |     3 | 18.27 μs | 0.151 μs | 0.134 μs |      31 B |
|           DoubleIncrementBitConverter |     65536 |                   ? |                   ? |     3 | 53.41 μs | 0.149 μs | 0.132 μs |      36 B |
|              DoubleIncrementVector128 |     65536 |                   ? |                   ? |     3 | 18.46 μs | 0.308 μs | 0.302 μs |      31 B |
|    **SingleConstInt32AndNotBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **53.56 μs** | **0.146 μs** | **0.130 μs** |      **46 B** |
|       SingleConstInt32AndNotVector128 |     65536 |                   3 |                   ? |     ? | 18.26 μs | 0.207 μs | 0.184 μs |      35 B |
|        **SingleSingleAndNotBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **53.50 μs** | **0.251 μs** | **0.223 μs** |      **45 B** |
|           SingleSingleAndNotVector128 |     65536 |                   3 |                   1 |     ? | 29.20 μs | 0.581 μs | 1.382 μs |      27 B |
| **SingleVariableInt32AndNotBitConverter** |     **65536** |                   **3** |          **1065353216** |     **?** | **55.24 μs** | **0.297 μs** | **0.278 μs** |      **40 B** |
|    SingleVariableInt32AndNotVector128 |     65536 |                   3 |          1065353216 |     ? | 20.04 μs | 0.324 μs | 0.303 μs |      32 B |
| **VariableInt32SingleAndNotBitConverter** |     **65536** |          **1065353216** |                   **1** |     **?** | **54.38 μs** | **0.274 μs** | **0.243 μs** |      **40 B** |
|    VariableInt32SingleAndNotVector128 |     65536 |          1065353216 |                   1 |     ? | 20.67 μs | 0.265 μs | 0.207 μs |      31 B |
|           **SingleDecrementBitConverter** |     **65536** |                   **?** |                   **?** |     **3** | **53.76 μs** | **0.228 μs** | **0.202 μs** |      **33 B** |
|              SingleDecrementVector128 |     65536 |                   ? |                   ? |     3 | 19.75 μs | 0.337 μs | 0.316 μs |      31 B |
|           SingleIncrementBitConverter |     65536 |                   ? |                   ? |     3 | 54.18 μs | 0.389 μs | 0.364 μs |      33 B |
|              SingleIncrementVector128 |     65536 |                   ? |                   ? |     3 | 19.92 μs | 0.389 μs | 0.400 μs |      31 B |

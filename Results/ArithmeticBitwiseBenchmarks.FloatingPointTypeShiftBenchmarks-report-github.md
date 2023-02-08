``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.200-preview.22628.1
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|                                       Method | LoopCount | value |     Mean |    Error |   StdDev |   Median | Code Size |
|--------------------------------------------- |---------- |------ |---------:|---------:|---------:|---------:|----------:|
|          DoubleConstIntLeftShiftBitConverter |     65536 |     3 | 53.70 μs | 0.190 μs | 0.178 μs | 53.70 μs |      37 B |
|             DoubleConstIntLeftShiftVector128 |     65536 |     3 | 18.14 μs | 0.067 μs | 0.056 μs | 18.13 μs |      28 B |
| DoubleConstIntUnsignedRightShiftBitConverter |     65536 |     3 | 53.46 μs | 0.149 μs | 0.139 μs | 53.46 μs |      37 B |
|    DoubleConstIntUnsignedRightShiftVector128 |     65536 |     3 | 18.19 μs | 0.121 μs | 0.107 μs | 18.19 μs |      28 B |
|          SingleConstIntLeftShiftBitConverter |     65536 |     3 | 53.48 μs | 0.216 μs | 0.181 μs | 53.44 μs |      34 B |
|             SingleConstIntLeftShiftVector128 |     65536 |     3 | 18.16 μs | 0.145 μs | 0.121 μs | 18.14 μs |      28 B |
|         SingleConstIntRightShiftBitConverter |     65536 |     3 | 53.46 μs | 0.152 μs | 0.135 μs | 53.49 μs |      34 B |
|            SingleConstIntRightShiftVector128 |     65536 |     3 | 18.16 μs | 0.142 μs | 0.126 μs | 18.14 μs |      28 B |
| SingleConstIntUnsignedRightShiftBitConverter |     65536 |     3 | 53.56 μs | 0.231 μs | 0.205 μs | 53.58 μs |      34 B |
|    SingleConstIntUnsignedRightShiftVector128 |     65536 |     3 | 18.65 μs | 0.371 μs | 0.679 μs | 18.33 μs |      28 B |

``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
Intel Core i7-4790 CPU 3.60GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.200-preview.22628.1
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|                                     Method | LoopCount |                left |               right | value |     Mean |    Error |   StdDev | Code Size |
|------------------------------------------- |---------- |-------------------- |-------------------- |------ |---------:|---------:|---------:|----------:|
|       **DoubleConstInt64AdditionBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.18 μs** | **0.158 μs** | **0.140 μs** |      **50 B** |
|          DoubleConstInt64AdditionVector128 |     65536 |                   3 |                   ? |     ? | 20.68 μs | 0.327 μs | 0.290 μs |      35 B |
|           **DoubleDoubleAdditionBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.23 μs** | **0.248 μs** | **0.232 μs** |      **45 B** |
|              DoubleDoubleAdditionVector128 |     65536 |                   3 |                   1 |     ? | 25.07 μs | 0.493 μs | 0.914 μs |      27 B |
|    **DoubleVariableInt64AdditionBitConverter** |     **65536** |                   **3** | **4607182418800017408** |     **?** | **54.04 μs** | **0.148 μs** | **0.131 μs** |      **36 B** |
|       DoubleVariableInt64AdditionVector128 |     65536 |                   3 | 4607182418800017408 |     ? | 20.57 μs | 0.127 μs | 0.119 μs |      32 B |
|     **DoubleConstInt64BitwiseAndBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.28 μs** | **0.309 μs** | **0.274 μs** |      **50 B** |
|        DoubleConstInt64BitwiseAndVector128 |     65536 |                   3 |                   ? |     ? | 18.51 μs | 0.159 μs | 0.149 μs |      35 B |
|         **DoubleDoubleBitwiseAndBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.23 μs** | **0.203 μs** | **0.190 μs** |      **45 B** |
|            DoubleDoubleBitwiseAndVector128 |     65536 |                   3 |                   1 |     ? | 23.58 μs | 0.470 μs | 1.143 μs |      27 B |
|  **DoubleVariableInt64BitwiseAndBitConverter** |     **65536** |                   **3** | **4607182418800017408** |     **?** | **54.28 μs** | **0.239 μs** | **0.212 μs** |      **36 B** |
|     DoubleVariableInt64BitwiseAndVector128 |     65536 |                   3 | 4607182418800017408 |     ? | 20.33 μs | 0.406 μs | 0.514 μs |      32 B |
|      **DoubleConstInt64BitwiseOrBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.24 μs** | **0.195 μs** | **0.173 μs** |      **50 B** |
|         DoubleConstInt64BitwiseOrVector128 |     65536 |                   3 |                   ? |     ? | 18.57 μs | 0.225 μs | 0.199 μs |      35 B |
|          **DoubleDoubleBitwiseOrBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.15 μs** | **0.272 μs** | **0.255 μs** |      **45 B** |
|             DoubleDoubleBitwiseOrVector128 |     65536 |                   3 |                   1 |     ? | 23.25 μs | 0.465 μs | 1.296 μs |      27 B |
|   **DoubleVariableInt64BitwiseOrBitConverter** |     **65536** |                   **3** | **4607182418800017408** |     **?** | **54.14 μs** | **0.237 μs** | **0.222 μs** |      **36 B** |
|      DoubleVariableInt64BitwiseOrVector128 |     65536 |                   3 | 4607182418800017408 |     ? | 18.57 μs | 0.163 μs | 0.153 μs |      32 B |
|    **DoubleConstInt64ExclusiveOrBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.26 μs** | **0.208 μs** | **0.194 μs** |      **50 B** |
|       DoubleConstInt64ExclusiveOrVector128 |     65536 |                   3 |                   ? |     ? | 18.54 μs | 0.190 μs | 0.159 μs |      35 B |
|        **DoubleDoubleExclusiveOrBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.21 μs** | **0.242 μs** | **0.189 μs** |      **45 B** |
|           DoubleDoubleExclusiveOrVector128 |     65536 |                   3 |                   1 |     ? | 28.96 μs | 0.572 μs | 0.856 μs |      27 B |
| **DoubleVariableInt64ExclusiveOrBitConverter** |     **65536** |                   **3** | **4607182418800017408** |     **?** | **54.26 μs** | **0.258 μs** | **0.242 μs** |      **36 B** |
|    DoubleVariableInt64ExclusiveOrVector128 |     65536 |                   3 | 4607182418800017408 |     ? | 18.54 μs | 0.152 μs | 0.135 μs |      32 B |
|    **ConstInt64DoubleSubtractionBitConverter** |     **65536** |                   **?** |                   **1** |     **?** | **72.16 μs** | **0.305 μs** | **0.271 μs** |      **53 B** |
|       ConstInt64DoubleSubtractionVector128 |     65536 |                   ? |                   1 |     ? | 20.63 μs | 0.209 μs | 0.174 μs |      35 B |
|    **DoubleConstInt64SubtractionBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.25 μs** | **0.346 μs** | **0.324 μs** |      **50 B** |
|       DoubleConstInt64SubtractionVector128 |     65536 |                   3 |                   ? |     ? | 20.57 μs | 0.156 μs | 0.146 μs |      35 B |
|        **DoubleDoubleSubtractionBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.15 μs** | **0.149 μs** | **0.140 μs** |      **45 B** |
|           DoubleDoubleSubtractionVector128 |     65536 |                   3 |                   1 |     ? | 26.96 μs | 0.517 μs | 0.741 μs |      27 B |
| **DoubleVariableInt64SubtractionBitConverter** |     **65536** |                   **3** | **4607182418800017408** |     **?** | **54.09 μs** | **0.207 μs** | **0.173 μs** |      **36 B** |
|    DoubleVariableInt64SubtractionVector128 |     65536 |                   3 | 4607182418800017408 |     ? | 20.84 μs | 0.177 μs | 0.166 μs |      32 B |
| **VariableInt64DoubleSubtractionBitConverter** |     **65536** | **4607182418800017408** |                   **1** |     **?** | **54.47 μs** | **0.506 μs** | **0.474 μs** |      **43 B** |
|    VariableInt64DoubleSubtractionVector128 |     65536 | 4607182418800017408 |                   1 |     ? | 20.69 μs | 0.275 μs | 0.244 μs |      32 B |
|           **DoubleOnesComplementBitConverter** |     **65536** |                   **?** |                   **?** |     **3** | **54.32 μs** | **0.252 μs** | **0.236 μs** |      **36 B** |
|              DoubleOnesComplementVector128 |     65536 |                   ? |                   ? |     3 | 19.31 μs | 0.263 μs | 0.220 μs |      31 B |
|            DoubleUnaryNegationBitConverter |     65536 |                   ? |                   ? |     3 | 54.22 μs | 0.147 μs | 0.130 μs |      36 B |
|               DoubleUnaryNegationVector128 |     65536 |                   ? |                   ? |     3 | 18.47 μs | 0.135 μs | 0.120 μs |      31 B |
|       **SingleConstInt32AdditionBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.06 μs** | **0.213 μs** | **0.178 μs** |      **41 B** |
|          SingleConstInt32AdditionVector128 |     65536 |                   3 |                   ? |     ? | 20.57 μs | 0.180 μs | 0.150 μs |      35 B |
|           **SingleSingleAdditionBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.15 μs** | **0.207 μs** | **0.193 μs** |      **43 B** |
|              SingleSingleAdditionVector128 |     65536 |                   3 |                   1 |     ? | 29.80 μs | 0.537 μs | 0.476 μs |      27 B |
|    **SingleVariableInt32AdditionBitConverter** |     **65536** |                   **3** |          **1065353216** |     **?** | **54.60 μs** | **0.611 μs** | **0.542 μs** |      **34 B** |
|       SingleVariableInt32AdditionVector128 |     65536 |                   3 |          1065353216 |     ? | 20.51 μs | 0.160 μs | 0.150 μs |      32 B |
|     **SingleConstInt32BitwiseAndBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.16 μs** | **0.173 μs** | **0.153 μs** |      **41 B** |
|        SingleConstInt32BitwiseAndVector128 |     65536 |                   3 |                   ? |     ? | 18.60 μs | 0.241 μs | 0.214 μs |      35 B |
|         **SingleSingleBitwiseAndBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.05 μs** | **0.189 μs** | **0.177 μs** |      **43 B** |
|            SingleSingleBitwiseAndVector128 |     65536 |                   3 |                   1 |     ? | 28.28 μs | 0.452 μs | 0.663 μs |      27 B |
|  **SingleVariableInt32BitwiseAndBitConverter** |     **65536** |                   **3** |          **1065353216** |     **?** | **54.14 μs** | **0.194 μs** | **0.172 μs** |      **34 B** |
|     SingleVariableInt32BitwiseAndVector128 |     65536 |                   3 |          1065353216 |     ? | 18.54 μs | 0.189 μs | 0.177 μs |      32 B |
|      **SingleConstInt32BitwiseOrBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.32 μs** | **0.232 μs** | **0.194 μs** |      **41 B** |
|         SingleConstInt32BitwiseOrVector128 |     65536 |                   3 |                   ? |     ? | 18.51 μs | 0.156 μs | 0.146 μs |      35 B |
|          **SingleSingleBitwiseOrBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.18 μs** | **0.232 μs** | **0.206 μs** |      **43 B** |
|             SingleSingleBitwiseOrVector128 |     65536 |                   3 |                   1 |     ? | 23.24 μs | 0.461 μs | 1.050 μs |      27 B |
|   **SingleVariableInt32BitwiseOrBitConverter** |     **65536** |                   **3** |          **1065353216** |     **?** | **55.00 μs** | **0.982 μs** | **0.964 μs** |      **34 B** |
|      SingleVariableInt32BitwiseOrVector128 |     65536 |                   3 |          1065353216 |     ? | 18.86 μs | 0.359 μs | 0.559 μs |      32 B |
|    **SingleConstInt32ExclusiveOrBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.09 μs** | **0.170 μs** | **0.142 μs** |      **41 B** |
|       SingleConstInt32ExclusiveOrVector128 |     65536 |                   3 |                   ? |     ? | 18.94 μs | 0.343 μs | 0.433 μs |      35 B |
|        **SingleSingleExclusiveOrBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.24 μs** | **0.244 μs** | **0.228 μs** |      **43 B** |
|           SingleSingleExclusiveOrVector128 |     65536 |                   3 |                   1 |     ? | 26.08 μs | 0.520 μs | 0.762 μs |      27 B |
| **SingleVariableInt32ExclusiveOrBitConverter** |     **65536** |                   **3** |          **1065353216** |     **?** | **54.01 μs** | **0.155 μs** | **0.137 μs** |      **34 B** |
|    SingleVariableInt32ExclusiveOrVector128 |     65536 |                   3 |          1065353216 |     ? | 18.51 μs | 0.132 μs | 0.117 μs |      32 B |
|    **ConstInt32SingleSubtractionBitConverter** |     **65536** |                   **?** |                   **1** |     **?** | **72.30 μs** | **0.614 μs** | **0.512 μs** |      **43 B** |
|       ConstInt32SingleSubtractionVector128 |     65536 |                   ? |                   1 |     ? | 20.53 μs | 0.162 μs | 0.152 μs |      35 B |
|    **SingleConstInt32SubtractionBitConverter** |     **65536** |                   **3** |                   **?** |     **?** | **54.18 μs** | **0.230 μs** | **0.215 μs** |      **41 B** |
|       SingleConstInt32SubtractionVector128 |     65536 |                   3 |                   ? |     ? | 20.58 μs | 0.131 μs | 0.109 μs |      35 B |
|        **SingleSingleSubtractionBitConverter** |     **65536** |                   **3** |                   **1** |     **?** | **54.24 μs** | **0.209 μs** | **0.195 μs** |      **43 B** |
|           SingleSingleSubtractionVector128 |     65536 |                   3 |                   1 |     ? | 24.94 μs | 0.498 μs | 1.231 μs |      27 B |
| **SingleVariableInt32SubtractionBitConverter** |     **65536** |                   **3** |          **1065353216** |     **?** | **54.84 μs** | **0.814 μs** | **0.762 μs** |      **34 B** |
|    SingleVariableInt32SubtractionVector128 |     65536 |                   3 |          1065353216 |     ? | 20.84 μs | 0.145 μs | 0.136 μs |      32 B |
| **VariableInt32SingleSubtractionBitConverter** |     **65536** |          **1065353216** |                   **1** |     **?** | **53.99 μs** | **0.185 μs** | **0.164 μs** |      **43 B** |
|    VariableInt32SingleSubtractionVector128 |     65536 |          1065353216 |                   1 |     ? | 20.62 μs | 0.126 μs | 0.111 μs |      31 B |
|           **SingleOnesComplementBitConverter** |     **65536** |                   **?** |                   **?** |     **3** | **54.10 μs** | **0.268 μs** | **0.238 μs** |      **33 B** |
|              SingleOnesComplementVector128 |     65536 |                   ? |                   ? |     3 | 19.17 μs | 0.199 μs | 0.186 μs |      31 B |
|            SingleUnaryNegationBitConverter |     65536 |                   ? |                   ? |     3 | 54.05 μs | 0.268 μs | 0.209 μs |      33 B |
|               SingleUnaryNegationVector128 |     65536 |                   ? |                   ? |     3 | 18.81 μs | 0.371 μs | 0.347 μs |      31 B |

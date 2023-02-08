## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64AdditionBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       mov       r8,3FF0000000000000
       add       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 50
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64AdditionVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72743A30]
M00_L00:
       vpaddq    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleAdditionBitConverter(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       vmovq     r8,xmm2
       add       rcx,r8
       vmovq     xmm2,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 45
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleAdditionVector128(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpaddq    xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64AdditionBitConverter(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       add       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64AdditionVector128(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovq     xmm0,r8
M00_L00:
       vpaddq    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64BitwiseAndBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       mov       r8,3FF0000000000000
       and       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 50
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64BitwiseAndVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72753A30]
M00_L00:
       vpand     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleBitwiseAndBitConverter(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       vmovq     r8,xmm2
       and       rcx,r8
       vmovq     xmm2,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 45
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleBitwiseAndVector128(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpand     xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64BitwiseAndBitConverter(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       and       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64BitwiseAndVector128(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovq     xmm0,r8
M00_L00:
       vpand     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64BitwiseOrBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       mov       r8,3FF0000000000000
       or        rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 50
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64BitwiseOrVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72723A30]
M00_L00:
       vpor      xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleBitwiseOrBitConverter(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       vmovq     r8,xmm2
       or        rcx,r8
       vmovq     xmm2,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 45
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleBitwiseOrVector128(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpor      xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64BitwiseOrBitConverter(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       or        rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64BitwiseOrVector128(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovq     xmm0,r8
M00_L00:
       vpor      xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64ExclusiveOrBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       mov       r8,3FF0000000000000
       xor       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 50
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64ExclusiveOrVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72743A30]
M00_L00:
       vpxor     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleExclusiveOrBitConverter(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       vmovq     r8,xmm2
       xor       rcx,r8
       vmovq     xmm2,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 45
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleExclusiveOrVector128(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpxor     xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64ExclusiveOrBitConverter(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       xor       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64ExclusiveOrVector128(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovq     xmm0,r8
M00_L00:
       vpxor     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.ConstInt64DoubleSubtractionBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       neg       rcx
       mov       r8,3FF0000000000000
       add       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 53
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.ConstInt64DoubleSubtractionVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72743A30]
M00_L00:
       vpsubq    xmm1,xmm0,xmm1
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64SubtractionBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       mov       r8,0C010000000000000
       add       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 50
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleConstInt64SubtractionVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72713A30]
M00_L00:
       vpsubq    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleSubtractionBitConverter(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       vmovq     r8,xmm2
       sub       rcx,r8
       vmovq     xmm2,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 45
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleDoubleSubtractionVector128(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpsubq    xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64SubtractionBitConverter(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       sub       rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleVariableInt64SubtractionVector128(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovq     xmm0,r8
M00_L00:
       vpsubq    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.VariableInt64DoubleSubtractionBitConverter(Int64, Double)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     r8,xmm2
       mov       r9,rdx
       sub       r9,r8
       vmovq     xmm2,r9
       inc       eax
       cmp       eax,ecx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.VariableInt64DoubleSubtractionVector128(Int64, Double)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       vmovq     xmm0,rdx
M00_L00:
       vpsubq    xmm2,xmm0,xmm2
       inc       eax
       cmp       eax,ecx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleOnesComplementBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       not       rcx
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleOnesComplementVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpcmpeqd  xmm0,xmm0,xmm0
       vpxor     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 31
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleUnaryNegationBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       neg       rcx
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.DoubleUnaryNegationVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vxorps    xmm0,xmm0,xmm0
       vpsubq    xmm1,xmm0,xmm1
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 31
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32AdditionBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       add       ecx,3F800000
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 41
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32AdditionVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72743A30]
M00_L00:
       vpaddd    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleAdditionBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       vmovd     r8d,xmm2
       add       ecx,r8d
       vmovd     xmm2,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleAdditionVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpaddd    xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32AdditionBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       add       ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 34
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32AdditionVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpaddd    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32BitwiseAndBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       and       ecx,3F800000
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 41
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32BitwiseAndVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72743A30]
M00_L00:
       vpand     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleBitwiseAndBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       vmovd     r8d,xmm2
       and       ecx,r8d
       vmovd     xmm2,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleBitwiseAndVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpand     xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32BitwiseAndBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       and       ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 34
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32BitwiseAndVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpand     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32BitwiseOrBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       or        ecx,3F800000
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 41
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32BitwiseOrVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72733A30]
M00_L00:
       vpor      xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleBitwiseOrBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       vmovd     r8d,xmm2
       or        ecx,r8d
       vmovd     xmm2,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleBitwiseOrVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpor      xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32BitwiseOrBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       or        ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 34
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32BitwiseOrVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpor      xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32ExclusiveOrBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       xor       ecx,3F800000
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 41
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32ExclusiveOrVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72733A30]
M00_L00:
       vpxor     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleExclusiveOrBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       vmovd     r8d,xmm2
       xor       ecx,r8d
       vmovd     xmm2,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleExclusiveOrVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpxor     xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32ExclusiveOrBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       xor       ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 34
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32ExclusiveOrVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpxor     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.ConstInt32SingleSubtractionBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       neg       ecx
       add       ecx,3F800000
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.ConstInt32SingleSubtractionVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72743A30]
M00_L00:
       vpsubd    xmm1,xmm0,xmm1
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32SubtractionBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       add       ecx,0C0800000
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 41
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleConstInt32SubtractionVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72723A30]
M00_L00:
       vpsubd    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 35
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleSubtractionBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       vmovd     r8d,xmm2
       sub       ecx,r8d
       vmovd     xmm2,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleSingleSubtractionVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpsubd    xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 27
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32SubtractionBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       sub       ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 34
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleVariableInt32SubtractionVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpsubd    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 32
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.VariableInt32SingleSubtractionBitConverter(Int32, Single)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     r8d,xmm2
       mov       r9d,edx
       sub       r9d,r8d
       vmovd     xmm2,r9d
       inc       eax
       cmp       eax,ecx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 43
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.VariableInt32SingleSubtractionVector128(Int32, Single)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       vmovd     xmm0,edx
M00_L00:
       vpsubd    xmm2,xmm0,xmm2
       inc       eax
       cmp       eax,ecx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 31
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleOnesComplementBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       not       ecx
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 33
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleOnesComplementVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpcmpeqd  xmm0,xmm0,xmm0
       vpxor     xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 31
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleUnaryNegationBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       neg       ecx
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 33
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeIntegerArithmeticBitwiseBenchmarks.SingleUnaryNegationVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vxorps    xmm0,xmm0,xmm0
       vpsubd    xmm1,xmm0,xmm1
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 31
```


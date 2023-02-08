## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleConstInt64AndNotBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       mov       r8,3FF0000000000000
       andn      rcx,rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 52
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleConstInt64AndNotVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFECB963A30]
M00_L00:
       vpandn    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleDoubleAndNotBitConverter(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm2
       vmovq     r8,xmm1
       andn      rcx,rcx,r8
       vmovq     xmm2,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 47
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleDoubleAndNotVector128(Double, Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpandn    xmm2,xmm2,xmm1
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleVariableInt64AndNotBitConverter(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovq     rcx,xmm1
       andn      rcx,rcx,r8
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 42
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleVariableInt64AndNotVector128(Double, Int64)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovq     xmm0,r8
M00_L00:
       vpandn    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.VariableInt64DoubleAndNotBitConverter(Int64, Double)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       not       rdx
       nop
M00_L00:
       vmovq     r8,xmm2
       and       r8,rdx
       vmovq     xmm2,r8
       inc       eax
       cmp       eax,ecx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 40
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.VariableInt64DoubleAndNotVector128(Int64, Double)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       vmovq     xmm0,rdx
M00_L00:
       vpandn    xmm2,xmm0,xmm2
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleDecrementBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       dec       rcx
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleDecrementVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpcmpeqd  xmm0,xmm0,xmm0
       vpaddq    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleIncrementBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       inc       rcx
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.DoubleIncrementVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpcmpeqd  xmm0,xmm0,xmm0
       vpsubq    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleConstInt32AndNotBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       mov       r8d,3F800000
       andn      ecx,ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 46
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleConstInt32AndNotVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFECB963A30]
M00_L00:
       vpandn    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleSingleAndNotBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm2
       vmovd     r8d,xmm1
       andn      ecx,ecx,r8d
       vmovd     xmm2,ecx
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleSingleAndNotVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpandn    xmm2,xmm2,xmm1
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleVariableInt32AndNotBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       andn      ecx,ecx,r8d
       vmovd     xmm1,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 40
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleVariableInt32AndNotVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpandn    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.VariableInt32SingleAndNotBitConverter(Int32, Single)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       not       edx
       xchg      ax,ax
M00_L00:
       vmovd     r8d,xmm2
       and       r8d,edx
       vmovd     xmm2,r8d
       inc       eax
       cmp       eax,ecx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 40
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.VariableInt32SingleAndNotVector128(Int32, Single)
       vzeroupper
       xor       eax,eax
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M00_L01
       vmovd     xmm0,edx
M00_L00:
       vpandn    xmm2,xmm0,xmm2
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleDecrementBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       dec       ecx
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleDecrementVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpcmpeqd  xmm0,xmm0,xmm0
       vpaddd    xmm1,xmm1,xmm0
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleIncrementBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       inc       ecx
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeSpecialOperatorBenchmarks.SingleIncrementVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpcmpeqd  xmm0,xmm0,xmm0
       vpsubd    xmm1,xmm1,xmm0
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 31
```


## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleSingleMultiplyBitConverter(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       vmovd     r8d,xmm2
       imul      ecx,r8d
       vmovd     xmm2,ecx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 44
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleSingleMultiplySse2(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpmuludq  xmm2,xmm1,xmm2
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
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleSingleMultiplyVector128(Single, Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpmulld   xmm2,xmm1,xmm2
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm2
       ret
; Total bytes of code 28
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleVariableInt32MultiplyBitConverter(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       imul      ecx,r8d
       vmovd     xmm1,ecx
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
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleVariableInt32MultiplySse2(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpmuludq  xmm1,xmm0,xmm1
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
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleVariableInt32MultiplyVector128(Single, Int32)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovd     xmm0,r8d
M00_L00:
       vpmulld   xmm1,xmm0,xmm1
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
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleConstInt32MultiplyBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax]
M00_L00:
       vmovd     ecx,xmm1
       imul      ecx,3F800000
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
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleConstInt32MultiplySse2(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72983A30]
M00_L00:
       vpmuludq  xmm1,xmm0,xmm1
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
; ArithmeticBitwiseBenchmarks.IntegerMultiplicationBenchmarks.SingleConstInt32MultiplyVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       vmovupd   xmm0,[7FFD72943A30]
M00_L00:
       vpmulld   xmm1,xmm0,xmm1
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 36
```


## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.DoubleConstIntLeftShiftBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       shl       rcx,0D
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 37
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.DoubleConstIntLeftShiftVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpsllq    xmm1,xmm1,0D
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 28
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.DoubleConstIntUnsignedRightShiftBitConverter(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovq     rcx,xmm1
       shr       rcx,0D
       vmovq     xmm1,rcx
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 37
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.DoubleConstIntUnsignedRightShiftVector128(Double)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpsrlq    xmm1,xmm1,0D
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 28
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.SingleConstIntLeftShiftBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       shl       ecx,0D
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.SingleConstIntLeftShiftVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpslld    xmm1,xmm1,0D
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 28
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.SingleConstIntRightShiftBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       sar       ecx,0D
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.SingleConstIntRightShiftVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpsrad    xmm1,xmm1,0D
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 28
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.SingleConstIntUnsignedRightShiftBitConverter(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vmovd     ecx,xmm1
       shr       ecx,0D
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
; ArithmeticBitwiseBenchmarks.FloatingPointTypeShiftBenchmarks.SingleConstIntUnsignedRightShiftVector128(Single)
       vzeroupper
       xor       eax,eax
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       vpsrld    xmm1,xmm1,0D
       inc       eax
       cmp       eax,edx
       jl        short M00_L00
M00_L01:
       vmovaps   xmm0,xmm1
       ret
; Total bytes of code 28
```


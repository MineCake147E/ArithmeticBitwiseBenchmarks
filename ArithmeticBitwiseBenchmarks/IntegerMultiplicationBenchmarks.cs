using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ArithmeticBitwiseBenchmarks
{
    [SimpleJob(runtimeMoniker: RuntimeMoniker.HostProcess)]
    //[ShortRunJob(runtimeMoniker: RuntimeMoniker.Net70)]
    //[DryJob]
    //[AllCategoriesFilter(CategoryOperatorExclusiveOr)]
    [DisassemblyDiagnoser(maxDepth: int.MaxValue)]
    public class IntegerMultiplicationBenchmarks
    {
        [Params(65536)]
        public int LoopCount { get; set; }
        #region Single With Single
        [Arguments(3.0f, 1.0f)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleSingleMultiplyBitConverter(float left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(left) * BitConverter.SingleToInt32Bits(acc));
            }
            return acc;
        }

        [Arguments(3.0f, 1.0f)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleSingleMultiplySse2(float left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Sse2.Multiply(Vector128.CreateScalarUnsafe(left).AsUInt32(), Vector128.CreateScalarUnsafe(acc).AsUInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        [Arguments(3.0f, 1.0f)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleSingleMultiplyVector128(float left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.Multiply(Vector128.CreateScalarUnsafe(left).AsUInt32(), Vector128.CreateScalarUnsafe(acc).AsUInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Single With Single

        #region Single With Constant Int32

        [Arguments(3.0f)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstInt32MultiplyBitConverter(float left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(acc) * 0x3f80_0000);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstInt32MultiplySse2(float left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Sse2.Multiply(Vector128.CreateScalarUnsafe(0x3f80_0000).AsUInt32(), Vector128.CreateScalarUnsafe(acc).AsUInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstInt32MultiplyVector128(float left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.Multiply(Vector128.CreateScalarUnsafe(0x3f80_0000).AsUInt32(), Vector128.CreateScalarUnsafe(acc).AsUInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Single With Constant Int32

        #region Single With Variable Int32 in GP register

        [Arguments(3.0f, 0x3f80_0000)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleVariableInt32MultiplyBitConverter(float left, int right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(acc) * right);
            }
            return acc;
        }

        [Arguments(3.0f, 0x3f80_0000)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleVariableInt32MultiplySse2(float left, int right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Sse2.Multiply(Vector128.CreateScalarUnsafe(right).AsUInt32(), Vector128.CreateScalarUnsafe(acc).AsUInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        [Arguments(3.0f, 0x3f80_0000)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleVariableInt32MultiplyVector128(float left, int right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.Multiply(Vector128.CreateScalarUnsafe(right).AsUInt32(), Vector128.CreateScalarUnsafe(acc).AsUInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Single With Variable Int32 in GP register
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using static ArithmeticBitwiseBenchmarks.BenchmarkCategories;

namespace ArithmeticBitwiseBenchmarks
{
    [SimpleJob(runtimeMoniker: RuntimeMoniker.HostProcess)]
    //[ShortRunJob(runtimeMoniker: RuntimeMoniker.Net70)]
    //[DryJob]
    [DisassemblyDiagnoser(maxDepth: int.MaxValue)]
    public class FloatingPointTypeSpecialOperatorBenchmarks
    {
        [Params(65536)]
        public int LoopCount { get; set; }

        #region Single

        #region AndNot

        #region Single With Single
        [Arguments(3.0f, 1.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithFloat, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleSingleAndNotBitConverter(float left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(left) & ~BitConverter.SingleToInt32Bits(acc));
            }
            return acc;
        }

        [Arguments(3.0f, 1.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithFloat, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleSingleAndNotVector128(float left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(left).AsInt32(), Vector128.CreateScalarUnsafe(acc).AsInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Single With Single

        #region Single With Constant Int32

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithConstInt, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstInt32AndNotBitConverter(float left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(~BitConverter.SingleToInt32Bits(acc) & 0x3f80_0000);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithConstInt, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstInt32AndNotVector128(float left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(0x3f80_0000), Vector128.CreateScalarUnsafe(acc).AsInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Single With Constant Int32

        #region Single With Variable Int32 in GP register

        [Arguments(3.0f, 0x3f80_0000)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithGPInt, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleVariableInt32AndNotBitConverter(float left, int right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(~BitConverter.SingleToInt32Bits(acc) & right);
            }
            return acc;
        }

        [Arguments(3.0f, 0x3f80_0000)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithGPInt, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleVariableInt32AndNotVector128(float left, int right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(right), Vector128.CreateScalarUnsafe(acc).AsInt32()).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Single With Variable Int32 in GP register

        #region Variable Int32 in GP register With Single
        [Arguments(0x3f80_0000, 1.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryGPIntWithFloat, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float VariableInt32SingleAndNotBitConverter(int left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(~left & BitConverter.SingleToInt32Bits(acc));
            }
            return acc;
        }

        [Arguments(0x3f80_0000, 1.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryOperatorAndNot, CategoryGPIntWithFloat, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float VariableInt32SingleAndNotVector128(int left, float right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(acc).AsInt32(), Vector128.CreateScalarUnsafe(left)).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Variable Int32 in GP register With Single

        #endregion AndNot

        #region Increment

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryUnary, CategoryOperatorIncrement, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleIncrementBitConverter(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(acc) + 1);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryUnary, CategoryOperatorIncrement, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleIncrementVector128(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = (Vector128.CreateScalarUnsafe(acc).AsInt32() - Vector128<int>.AllBitsSet).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Increment

        #region Decrement

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryUnary, CategoryOperatorDecrement, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleDecrementBitConverter(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(acc) - 1);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryUnary, CategoryOperatorDecrement, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleDecrementVector128(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = (Vector128.CreateScalarUnsafe(acc).AsInt32() + Vector128<int>.AllBitsSet).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion Decrement

        #endregion

        #region Double

        #region AndNot

        #region Double With Double
        [Arguments(3.0, 1.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithFloat, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleDoubleAndNotBitConverter(double left, double right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(left) & ~BitConverter.DoubleToInt64Bits(acc));
            }
            return acc;
        }

        [Arguments(3.0, 1.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithFloat, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleDoubleAndNotVector128(double left, double right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(left).AsInt64(), Vector128.CreateScalarUnsafe(acc).AsInt64()).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion Double With Double

        #region Double With Constant Int64

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithConstInt, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleConstInt64AndNotBitConverter(double left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(~BitConverter.DoubleToInt64Bits(acc) & 0x3FF0_0000_0000_0000L);
            }
            return acc;
        }

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithConstInt, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleConstInt64AndNotVector128(double left)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(0x3FF0_0000_0000_0000L), Vector128.CreateScalarUnsafe(acc).AsInt64()).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion Double With Constant Int64

        #region Double With Variable Int64 in GP register

        [Arguments(3.0, 0x3FF0_0000_0000_0000L)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithGPInt, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleVariableInt64AndNotBitConverter(double left, long right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(~BitConverter.DoubleToInt64Bits(acc) & right);
            }
            return acc;
        }

        [Arguments(3.0, 0x3FF0_0000_0000_0000L)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryFloatWithGPInt, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleVariableInt64AndNotVector128(double left, long right)
        {
            var acc = left;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(right), Vector128.CreateScalarUnsafe(acc).AsInt64()).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion Double With Variable Int64 in GP register

        #region Variable Int64 in GP register With Double
        [Arguments(0x3FF0_0000_0000_0000L, 1.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryGPIntWithFloat, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double VariableInt64DoubleAndNotBitConverter(long left, double right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(~left & BitConverter.DoubleToInt64Bits(acc));
            }
            return acc;
        }

        [Arguments(0x3FF0_0000_0000_0000L, 1.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryOperatorAndNot, CategoryGPIntWithFloat, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double VariableInt64DoubleAndNotVector128(long left, double right)
        {
            var acc = right;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.AndNot(Vector128.CreateScalarUnsafe(acc).AsInt64(), Vector128.CreateScalarUnsafe(left)).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion Variable Int64 in GP register With Double

        #endregion AndNot

        #region Increment

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryUnary, CategoryOperatorIncrement, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleIncrementBitConverter(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(acc) + 1);
            }
            return acc;
        }

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryUnary, CategoryOperatorIncrement, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleIncrementVector128(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = (Vector128.CreateScalarUnsafe(acc).AsInt64() - Vector128<long>.AllBitsSet).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion Increment

        #region Decrement

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryUnary, CategoryOperatorDecrement, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleDecrementBitConverter(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(acc) - 1);
            }
            return acc;
        }

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryUnary, CategoryOperatorDecrement, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleDecrementVector128(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = (Vector128.CreateScalarUnsafe(acc).AsInt64() + Vector128<long>.AllBitsSet).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion Decrement

        #endregion
    }
}

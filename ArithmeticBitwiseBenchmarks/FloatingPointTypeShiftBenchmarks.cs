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
    public class FloatingPointTypeShiftBenchmarks
    {
        [Params(65536)]
        public int LoopCount { get; set; }

        #region Single

        #region LeftShift

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorLeftShift, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstIntLeftShiftBitConverter(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(acc) << 13);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorLeftShift, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstIntLeftShiftVector128(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.ShiftLeft(Vector128.CreateScalarUnsafe(acc).AsInt32(), 13).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion

        #region UnsignedRightShift

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorUnsignedRightShift, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstIntUnsignedRightShiftBitConverter(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.UInt32BitsToSingle(BitConverter.SingleToUInt32Bits(acc) >> 13);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorUnsignedRightShift, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstIntUnsignedRightShiftVector128(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.ShiftRightLogical(Vector128.CreateScalarUnsafe(acc).AsUInt32(), 13).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion

        #region RightShift

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorRightShift, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstIntRightShiftBitConverter(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits(acc) >> 13);
            }
            return acc;
        }

        [Arguments(3.0f)]
        [BenchmarkCategory(CategoryTypeSingle, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorRightShift, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public float SingleConstIntRightShiftVector128(float value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.ShiftRightArithmetic(Vector128.CreateScalarUnsafe(acc).AsInt32(), 13).AsSingle().GetElement(0);
            }
            return acc;
        }

        #endregion

        #endregion
        #region Double

        #region LeftShift

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorLeftShift, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleConstIntLeftShiftBitConverter(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits(acc) << 13);
            }
            return acc;
        }

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorLeftShift, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleConstIntLeftShiftVector128(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.ShiftLeft(Vector128.CreateScalarUnsafe(acc).AsInt64(), 13).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion

        #region UnsignedRightShift

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorUnsignedRightShift, CategoryBitConverter)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleConstIntUnsignedRightShiftBitConverter(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(acc) >> 13);
            }
            return acc;
        }

        [Arguments(3.0)]
        [BenchmarkCategory(CategoryTypeDouble, CategoryBinary, CategoryFloatWithConstInt, CategoryOperatorUnsignedRightShift, CategoryVector128)]
        [Benchmark, MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public double DoubleConstIntUnsignedRightShiftVector128(double value)
        {
            var acc = value;
            for (int i = 0; i < LoopCount; i++)
            {
                acc = Vector128.ShiftRightLogical(Vector128.CreateScalarUnsafe(acc).AsUInt64(), 13).AsDouble().GetElement(0);
            }
            return acc;
        }

        #endregion

        #endregion
    }
}

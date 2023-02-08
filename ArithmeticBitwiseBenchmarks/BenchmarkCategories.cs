using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticBitwiseBenchmarks
{
    public static partial class BenchmarkCategories
    {
        public const string CategoryBitConverter = "BitConverter";
        public const string CategoryVector128 = "Vector128";
        public const string CategoryIntrinsics = "Intrinsics";
        public const string CategoryFloatWithFloat = "FloatWithFloat";
        public const string CategoryFloatWithConstInt = "FloatWithConstInt";
        public const string CategoryConstIntWithFloat = "ConstIntWithFloat";
        public const string CategoryFloatWithGPInt = "FloatWithGPInt";
        public const string CategoryGPIntWithFloat = "GPIntWithFloat";
        public const string CategoryBinary = "Binary";
        public const string CategoryUnary = "Unary";
    }
}

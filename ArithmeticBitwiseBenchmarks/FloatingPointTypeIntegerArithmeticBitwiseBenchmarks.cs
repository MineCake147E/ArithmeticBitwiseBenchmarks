using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace ArithmeticBitwiseBenchmarks
{
    [SimpleJob(runtimeMoniker: RuntimeMoniker.HostProcess)]
    //[ShortRunJob(runtimeMoniker: RuntimeMoniker.Net70)]
    //[DryJob]
    //[AllCategoriesFilter(CategoryOperatorExclusiveOr)]
    [DisassemblyDiagnoser(maxDepth: int.MaxValue)]
    public partial class FloatingPointTypeIntegerArithmeticBitwiseBenchmarks
    {
        private const string CategoryBitConverter = "BitConverter";
        private const string CategoryVector128 = "Vector128";
        private const string CategoryFloatWithFloat = "FloatWithFloat";
        private const string CategoryFloatWithConstInt = "FloatWithConstInt";
        private const string CategoryConstIntWithFloat = "ConstIntWithFloat";
        private const string CategoryFloatWithGPInt = "FloatWithGPInt";
        private const string CategoryGPIntWithFloat = "GPIntWithFloat";
        private const string CategoryBinary = "Binary";
        private const string CategoryUnary = "Unary";

        [Params(65536)]
        public int LoopCount { get; set; }
    }
}

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
        [Params(65536)]
        public int LoopCount { get; set; }
    }
}

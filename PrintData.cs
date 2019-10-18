using System;
using System.Collections.Generic;

namespace BenchmarkLab {
    class PrintData : Benchmark {
        protected override void PrintFirstRows() {
            Console.WriteLine("CPU: {0}, {1} cores,  1 core in use", CPU.getInfo("Name"), CPU.getInfo("NumberOfCores"));
            Console.WriteLine("Number of operations: {0:#.##e+0}", NumOfIterations);
            Console.WriteLine("{0, -14} {1, -12}  {2, -12}  {3, -12}  {4, -40}", "Operations", "Time(ms)", "%", "Op/Sec", "Perfomance line");
        }
        protected override void printResults(List<List<DataRow>> typesTestsResults) {
            foreach (List<DataRow> type in typesTestsResults)
                foreach (DataRow row in type)
                    Console.WriteLine("{0, -14} {1, -12:F2} {2, -12:P2} {3, -12:e} {4, -42}", row.DataType, row.Time, row.Percent/100, row.OpPerSec, row.PerfomanceLine);
        }
    }
}
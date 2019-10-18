using System;
using System.Collections.Generic;

namespace BenchmarkLab {
    class Benchmark {
        protected const uint NumOfIterations = 1000 * 1000 * 30;
        public class DataRow {
            public string DataType { get; set; }
            public double Time { get; set; }
            public double Percent { get; set; }
            public double OpPerSec { get; set; }
            public string PerfomanceLine { get; set; }
        }
        protected static List<List<DataRow>> typesTestsResults = new List<List<DataRow>>();
        protected virtual void PrintFirstRows() { }
        protected virtual void printResults(List<List<DataRow>> testsResults) { }

        public static void processBenchmark() {
            PrintData printer = new PrintData();
            printer.PrintFirstRows();

            List<Type> typesLs = new List<Type> { typeof(Int32), typeof(UInt32), 
                                                  typeof(Int64), typeof(UInt64), 
                                                  typeof(Single), typeof(Double) };

            foreach (Type t in typesLs) {
                try {
                    TypeTestsList testsLs = new TypeTestsList(t);
                    TimeMeasureForType typeMeasures = new TimeMeasureForType(t, testsLs.typeTestsList);
                    typesTestsResults.Add(typeMeasures.typeResults);
                } catch(ArgumentException ae) {
                    System.Diagnostics.Trace.WriteLine(ae.Message);
                    Console.ReadKey();
                    System.Environment.Exit(1);
                }
            }
            PercentRevaluateFunc.CountPercents();
            printer.printResults(typesTestsResults);
        }
    }
}
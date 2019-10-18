using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace BenchmarkLab {
    class TimeMeasureForType : Benchmark {
        private static double generalInitTime = getInitTime();
        private static double getInitTime() {
            Stopwatch sw = new Stopwatch();
            sw.Start();
                uint x = 1;
                for (uint i = 0; i < NumOfIterations; ++i) {
                    x = i;
                    x = i;
                    x = i;
                    x = i;
                }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        private static bool isFirstMeasurement = true;
        public static double minExecTime { get; private set; } = 0;

        public TimeMeasureForType(Type t, List<Action> testsLs) {
            for(int i = 0; i < testsLs.Count; ++i) {
                preparationsForTest(testsLs[i]);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                    testsLs[i]();
                sw.Stop();

                if (isFirstMeasurement == true || sw.Elapsed.TotalMilliseconds - generalInitTime < minExecTime) {
                    minExecTime = sw.Elapsed.TotalMilliseconds - generalInitTime;
                    isFirstMeasurement = false;
                }

                string operation = string.Empty;
                if (i == 0)
                    operation = " +";
                else if (i == 1)
                    operation = " -";
                else if (i == 2)
                    operation = " *";
                else
                    operation = " /";

                typeResults.Add(new DataRow { DataType = t.Name + operation, Time = sw.Elapsed.TotalMilliseconds - generalInitTime,
                                              OpPerSec = getOpPerSec(sw.Elapsed.TotalMilliseconds - generalInitTime) });
            }
        }

        public List<DataRow> typeResults { get; private set; } = new List<DataRow>();
        
        private void preparationsForTest(Action warmUpTest) {
            //prevent the JIT Compiler from optimizing Fkt calls away
            long seed = Environment.TickCount;

            ////use the second Core/Processor for the test
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(3);

            //prevent "Normal" Processes from interrupting Threads
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            //prevent "Normal" Threads from interrupting this thread
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            // A Warmup of 1000-1500 mS 
            // stabilizes the CPU cache and pipeline.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < 1500)
                warmUpTest(); 
            sw.Stop();

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private double getOpPerSec(double execTime) {
            return NumOfIterations * 1e3 / execTime;
        }
    }
}
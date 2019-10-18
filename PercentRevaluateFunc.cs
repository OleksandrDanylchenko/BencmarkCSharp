using System;

namespace BenchmarkLab {
    internal class PercentRevaluateFunc : Benchmark {
        public static void CountPercents() {
            for (int i = 0; i < typesTestsResults.Count; ++i)
                for (int j = 0; j < typesTestsResults[i].Count; ++j) {
                    typesTestsResults[i][j].Percent = getPercent(typesTestsResults[i][j].Time);
                    typesTestsResults[i][j].PerfomanceLine = measurePerfomanceLine(typesTestsResults[i][j].Percent);
                }
        }

        private static double getPercent(double execTime) {
            return TimeMeasureForType.minExecTime * 100 / execTime;
        }
        private static string measurePerfomanceLine(double percent) {
            int maxLength = 42;
            if (percent >= 100)
                return new string('#', maxLength);
            else
                return new string('#', (int)Math.Ceiling(percent * maxLength / 100));
        }
    }
}

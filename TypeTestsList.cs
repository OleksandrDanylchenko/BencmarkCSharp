using System;
using System.Collections.Generic;

namespace BenchmarkLab {
    class TypeTestsList : Benchmark {
        public TypeTestsList(Type type) {
            if (type == typeof(Int32)) {
                typeTestsList.Add(() => {
                    int a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b + c; b = a + c; c = a + b; d = c + b; b = c + d; }
                });
                typeTestsList.Add(() => {
                    int a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b - c; b = a - c; c = a - b; d = c - b; b = c - d; }
                });
                typeTestsList.Add(() => {
                    int a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b * c; b = a * c; c = a * b; d = c * b; b = c * d; }
                });
                typeTestsList.Add(() => {
                    int a = 1, b = 1, c = 1, d = 1;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b / c; b = a / c; c = a / b; d = c / b; b = c / d; }
                });
            } else if (type == typeof(UInt32)) {
                typeTestsList.Add(() => {
                    uint a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b + c; b = a + c; c = a + b; d = c + b; b = c + d; }
                });
                typeTestsList.Add(() => {
                    uint a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b - c; b = a - c; c = a - b; d = c - b; b = c - d; }
                });
                typeTestsList.Add(() => {
                    uint a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b * c; b = a * c; c = a * b; d = c * b; b = c * d; }
                });
                typeTestsList.Add(() => {
                    uint a = 1, b = 1, c = 1, d = 1;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b / c; b = a / c; c = a / b; d = c / b; b = c / d; }
                });
            } else if (type == typeof(Int64)) {
                typeTestsList.Add(() => {
                    long a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b + c; b = a + c; c = a + b; d = c + b; b = c + d; }
                });
                typeTestsList.Add(() => {
                    long a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b - c; b = a - c; c = a - b; d = c - b; b = c - d; }
                });
                typeTestsList.Add(() => {
                    long a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b * c; b = a * c; c = a * b; d = c * b; b = c * d; }
                });
                typeTestsList.Add(() => {
                    long a = 1, b = 1, c = 1, d = 1;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b / c; b = a / c; c = a / b; d = c / b; b = c / d; }
                });
            } else if (type == typeof(UInt64)) {
                typeTestsList.Add(() => {
                    ulong a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b + c; b = a + c; c = a + b; d = c + b; b = c + d; }
                });
                typeTestsList.Add(() => {
                    ulong a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b - c; b = a - c; c = a - b; d = c - b; b = c - d; }
                });
                typeTestsList.Add(() => {
                    ulong a = 2, b = 2, c = 1, d = 4;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b * c; b = a * c; c = a * b; d = c * b; b = c * d; }
                });
                typeTestsList.Add(() => {
                    ulong a = 1, b = 1, c = 1, d = 1;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b / c; b = a / c; c = a / b; d = c / b; b = c / d; }
                });
            } else if (type == typeof(Single)) {
                typeTestsList.Add(() => {
                    float a = 2f, b = 2f, c = 1f, d = 4f;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b + c; b = a + c; c = a + b; d = c + b; b = c + d; }
                });
                typeTestsList.Add(() => {
                    float a = 2f, b = 2f, c = 1f, d = 4f;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b - c; b = a - c; c = a - b; d = c - b; b = c - d; }
                });
                typeTestsList.Add(() => {
                    float a = 2f, b = 2f, c = 1f, d = 4f;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b * c; b = a * c; c = a * b; d = c * b; b = c * d; }
                });
                typeTestsList.Add(() => {
                    float a = 1, b = 1, c = 1, d = 1;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b / c; b = a / c; c = a / b; d = c / b; b = c / d; }
                });
            } else if (type == typeof(Double)) {
                typeTestsList.Add(() => {
                    double a = 2d, b = 2d, c = 1d, d = 4d;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b + c; b = a + c; c = a + b; d = c + b; b = c + d; }
                });
                typeTestsList.Add(() => {
                    double a = 2d, b = 2d, c = 1d, d = 4d;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b - c; b = a - c; c = a - b; d = c - b; b = c - d; }
                });
                typeTestsList.Add(() => {
                    double a = 3d, b = 7d, c = 3d, d = 7d;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b * c; b = a * c; c = a * b; d = c * b; b = c * d; }
                });
                typeTestsList.Add(() => {
                    double a = double.MaxValue, b = 7, c = double.MaxValue, d = double.MaxValue;
                    for (uint i = 0; i < NumOfIterations; ++i) { a = b / c; b = a / c; c = a / b; d = c / b; b = c / d; }
                });
            } else
                throw new System.ArgumentException("Unknown type of argument within type tests creation!");
        }
        public List<Action> typeTestsList { get; private set; } = new List<Action>();
    }
}
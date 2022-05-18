using CleanMetrics.Abstractions.Metrics;
using CleanMetrics.Abstractions.Metrics.Measures;
using System;

namespace CleanMetrics.Abstractions
{
    public interface IMetricsContext : IDisposable
    {
        IMeasureRepository<Measure> MeasureRepository { get; }
    }
}

using CleanMetrics.Abstractions;
using CleanMetrics.Metrics;
using CleanMetrics.Metrics.Measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMetrics
{
    public sealed class CleanMetrics
    {
        private readonly IMetricsContext localContext;
        private readonly IMetricsContext remoteContext;

        public CleanMetrics(IMetricsContext mainContext, IMetricsContext altContext)
        {
            localContext = mainContext;
            remoteContext = altContext;

            MeasureService = new MeasureService();
        }

        public MeasureService MeasureService { get; }
    }
}

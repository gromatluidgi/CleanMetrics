using CleanMetrics.Abstractions.Metrics.Measures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanMetrics.Abstractions.Metrics
{
    public interface IMeasureService
    {
        Task<Measure> GetAll();
    }
}

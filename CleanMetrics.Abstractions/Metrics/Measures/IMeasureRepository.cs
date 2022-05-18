using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanMetrics.Abstractions.Metrics
{
    public interface IMeasureRepository<TMetric>
        where TMetric : Metric
    {
        Task<IEnumerable<TMetric>> GetAll();
    }
}

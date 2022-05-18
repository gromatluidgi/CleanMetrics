using CleanMetrics.Abstractions;
using CleanMetrics.Abstractions.Metrics;
using CleanMetrics.Abstractions.Metrics.Measures;
using CleanMetrics.Persistence.LiteDB.Metrics;
using LiteDB;
using System;

namespace CleanMetrics.Persistence.LiteDB
{
    public class LiteDBContext : IMetricsContext
    {
        private bool disposedValue;

        public LiteDBContext(LiteDatabase database)
        {
            Database = database;
            MeasureRepository = new LiteMeasureRepository(database);
        }

        public LiteDatabase Database { get; }

        public IMeasureRepository<Measure> MeasureRepository { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Database.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

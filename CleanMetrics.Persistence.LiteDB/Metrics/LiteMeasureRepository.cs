using CleanMetrics.Abstractions.Metrics;
using CleanMetrics.Abstractions.Metrics.Measures;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanMetrics.Persistence.LiteDB.Metrics
{
    public sealed class LiteMeasureRepository : IMeasureRepository<Measure>
    {
        private readonly ILiteDatabase database;

        public LiteMeasureRepository(ILiteDatabase liteDatabase)
        {
            database = liteDatabase;
        }

        public ILiteCollection<MeasureDocument> MeasureCollection
        {
            get
            {
                return database.GetCollection<MeasureDocument>(nameof(Measure));
            }
        }

        public Task<IEnumerable<Measure>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

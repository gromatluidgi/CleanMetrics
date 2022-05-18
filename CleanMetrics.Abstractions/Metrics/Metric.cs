using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanMetrics.Abstractions.Metrics
{
    /// <summary>
    /// See SMM Spec. - Section 8.2 SmmElement Class (Abstract)
    /// </summary>
    public abstract class Metric
    {
        protected string? Name { get; set; }

        protected string? Description { get; set; }
        
        protected string? ShortDescription { get; set; }

        /// <summary>
        /// The set of relationship such that the current Metric is the to-endpoint
        /// of these relations.This property is a derived union.
        /// </summary>
        protected ISet<Metric> Inbound { get; } = new HashSet<Metric>();

        /// <summary>
        /// The set of relationship such that the current Metric is the fromendpoint of these relations. 
        /// This property is a derived union.
        /// </summary>
        protected ISet<Metric> Outbound { get; } = new HashSet<Metric>();


        protected Metric() { 
        }
        
    }
}

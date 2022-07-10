using System.Collections.Generic;
using Kyocera.Ilsa.Reads.Contracts.ViewModels.Configurations;

namespace Kyocera.Ilsa.Models.Configurations.DailyReport
{
    /// <summary>
    /// Defines the <see cref="DailyReportForm" />.
    /// </summary>
    public class DailyReportForm
    {
        /// <summary>
        /// Gets or sets the IdFileContainerReport.
        /// </summary>
        public int IdFileContainerReport { get; set; }

        /// <summary>
        /// Gets or sets the IdFileContainerAttendingEvalutions.
        /// </summary>
        public int IdFileContainerAttendingEvalutions { get; set; }

        /// <summary>
        /// Gets or sets the IdFileContainerRoutes.
        /// </summary>
        public int IdFileContainerRoutes { get; set; }

        /// <summary>
        /// Gets or sets the MetadatasReport.
        /// </summary>
        public MetadatasReport MetadatasReport { get; set; }

        /// <summary>
        /// Gets or sets the MetadatasAttendingEvaluations.
        /// </summary>
        public MetadatasAttendingEvaluations MetadatasAttendingEvaluations { get; set; }

        /// <summary>
        /// Gets or sets the MetadatasJourneys.
        /// </summary>
        public MetadatasJourneys MetadatasJourneys { get; set; }

        /// <summary>
        /// Gets or sets the Blocks.
        /// </summary>
        public List<Blocks> Blocks { get; set; }

        /// <summary>
        /// Gets or sets the Questions.
        /// </summary>
        public List<Questions> Questions { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Kyocera.Ilsa.Models.DailyReports.Assistants
{
    /// <summary>
    /// Defines the <see cref="AssistantViewModel" />.
    /// </summary>
    public class AssistantViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantViewModel"/> class.
        /// </summary>
        public AssistantViewModel()
        {
            this.GlobalEvaluations = new List<GlobalEvaluationViewModel>();
        }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the GlobalEvaluations.
        /// </summary>
        public List<GlobalEvaluationViewModel> GlobalEvaluations { get; set; }

        /// <summary>
        /// Gets or sets the Observations.
        /// </summary>
        public string Observations { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            return this.GlobalEvaluations.Count > 0 && this.GlobalEvaluations.TrueForAll(s => s.IsValid()) && !string.IsNullOrWhiteSpace(this.Name);
        }

        /// <summary>
        /// The GetAverageBlocks.
        /// </summary>
        /// <returns>The <see cref="List{AvgBlocks}"/>.</returns>
        public List<AvgBlocks> GetAverageBlocks()
        {
            return this.GlobalEvaluations.GroupBy(t => new { Id = t.IdBlock }).Select(g => new AvgBlocks(g.Key.Id, g.Average(p => p.Evaluation))).ToList();
        }

        /// <summary>
        /// The GetAverageEvalutionTotal.
        /// </summary>
        /// <returns>The <see cref="double"/>.</returns>
        public double GetAverageEvalutionTotal()
        {
            return this.GetAverageBlocks().Average(a => a.Average);
        }
    }
}
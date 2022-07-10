namespace Kyocera.Ilsa.Models.DailyReports.Assistants
{
    /// <summary>
    /// Defines the <see cref="GlobalEvaluationViewModel" />.
    /// </summary>
    public class GlobalEvaluationViewModel
    {
        /// <summary>
        /// Gets or sets the IdBlock.
        /// </summary>
        public int IdBlock { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Question.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the Evaluation.
        /// </summary>
        public int Evaluation { get; set; }

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
            return this.Evaluation > 0 && this.Evaluation < 6;
        }
    }
}

namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Security
{
    /// <summary>
    /// Defines the <see cref="EvaluationSecurity" />.
    /// </summary>
    public class EvaluationSecurity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSecurity"/> class.
        /// </summary>
        public EvaluationSecurity()
        {
            this.Evaluation = EvaluationEnumeration.OK;
        }

        /// <summary>
        /// Gets or sets the Evaluation.
        /// </summary>
        public EvaluationEnumeration Evaluation { get; set; }

        /// <summary>
        /// Gets or sets the NumTrain.
        /// </summary>
        public string NumTrain { get; set; }

        /// <summary>
        /// Gets or sets the Observation.
        /// </summary>
        public string Observation { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            if (this.Evaluation == EvaluationEnumeration.OK)
            {
                return true;
            }

            return this.Evaluation == EvaluationEnumeration.NO_OK && !string.IsNullOrWhiteSpace(this.NumTrain) && !string.IsNullOrWhiteSpace(this.Observation);
        }
    }
}

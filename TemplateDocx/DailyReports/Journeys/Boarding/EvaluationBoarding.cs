namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Boarding
{
    /// <summary>
    /// Defines the <see cref="EvaluationBoarding" />.
    /// </summary>
    public class EvaluationBoarding
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationBoarding"/> class.
        /// </summary>
        public EvaluationBoarding()
        {
            this.Evaluation = EvaluationEnumeration.OK;
        }

        /// <summary>
        /// Gets or sets the Evaluation.
        /// </summary>
        public EvaluationEnumeration Evaluation { get; set; }

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
            if (this.Evaluation == EvaluationEnumeration.OK)
            {
                return true;
            }

            return this.Evaluation == EvaluationEnumeration.NO_OK && !string.IsNullOrWhiteSpace(this.Observations);
        }
    }
}

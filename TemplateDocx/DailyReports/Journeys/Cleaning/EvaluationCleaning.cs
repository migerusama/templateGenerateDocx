namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Cleaning
{
    /// <summary>
    /// Defines the <see cref="EvaluationCleaning" />.
    /// </summary>
    public class EvaluationCleaning
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCleaning"/> class.
        /// </summary>
        public EvaluationCleaning()
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
        /// Gets or sets the Classification.
        /// </summary>
        public ClassificationEnumeration Classification { get; set; }

        /// <summary>
        /// Gets or sets the Comment.
        /// </summary>
        public string Comment { get; set; }

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

            return this.Evaluation == EvaluationEnumeration.NO_OK && !string.IsNullOrWhiteSpace(this.NumTrain) && !string.IsNullOrWhiteSpace(this.Comment);
        }
    }
}

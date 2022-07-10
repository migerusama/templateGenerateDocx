namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Gastronomy
{
    /// <summary>
    /// Defines the <see cref="EvaluationGastronomyCafeteriaGategourmet" />.
    /// </summary>
    public class EvaluationGastronomyCafeteriaGategourmet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationGastronomyCafeteriaGategourmet"/> class.
        /// </summary>
        public EvaluationGastronomyCafeteriaGategourmet()
        {
            this.Evaluation = EvaluationEnumeration.OK;
        }

        /// <summary>
        /// Gets or sets the Evaluation.
        /// </summary>
        public EvaluationEnumeration Evaluation { get; set; }

        /// <summary>
        /// Gets or sets the Detail.
        /// </summary>
        public DetailCafeteriaGategourmetEnumeration Detail { get; set; }

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

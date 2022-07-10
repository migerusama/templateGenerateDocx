namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Gastronomy
{
    /// <summary>
    /// Defines the <see cref="EvaluationGastronomyEquipment" />.
    /// </summary>
    public class EvaluationGastronomyEquipment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationGastronomyEquipment"/> class.
        /// </summary>
        public EvaluationGastronomyEquipment()
        {
            this.Evaluation = EvaluationEnumeration.OK;
            this.Trolly = new TrollyViewModel();
        }

        /// <summary>
        /// Gets or sets the Evaluation.
        /// </summary>
        public EvaluationEnumeration Evaluation { get; set; }

        /// <summary>
        /// Gets or sets the Detail.
        /// </summary>
        public DetailEquipmentEnumeration Detail { get; set; }

        /// <summary>
        /// Gets or sets the Observations.
        /// </summary>
        public string Observations { get; set; }

        /// <summary>
        /// Gets or sets the Trolly.
        /// </summary>
        public TrollyViewModel Trolly { get; set; }

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

            var trollyValidation = true;

            if (this.Detail == DetailEquipmentEnumeration.Full_Trolly
                || this.Detail == DetailEquipmentEnumeration.Half_Trolly
                || this.Detail == DetailEquipmentEnumeration.Waste_Trolly)
            {
                trollyValidation = this.Trolly.IsValid();
            }

            return this.Evaluation == EvaluationEnumeration.NO_OK && !string.IsNullOrWhiteSpace(this.Observations) && trollyValidation;
        }
    }
}

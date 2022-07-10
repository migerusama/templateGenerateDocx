namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Gastronomy
{
    /// <summary>
    /// Defines the <see cref="TrollyViewModel" />.
    /// </summary>
    public class TrollyViewModel
    {
        /// <summary>
        /// Gets or sets the TrollyNumber.
        /// </summary>
        public string TrollyNumber { get; set; }

        /// <summary>
        /// Gets or sets the Detail.
        /// </summary>
        public DetailTrollyEnumeration Detail { get; set; }

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
            return !string.IsNullOrWhiteSpace(this.TrollyNumber) && !string.IsNullOrWhiteSpace(this.Observation);
        }
    }
}

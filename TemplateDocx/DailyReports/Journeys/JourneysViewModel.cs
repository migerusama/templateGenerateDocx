using Kyocera.Ilsa.Models.DailyReports.Journeys.Boarding;
using Kyocera.Ilsa.Models.DailyReports.Journeys.Cleaning;
using Kyocera.Ilsa.Models.DailyReports.Journeys.Gastronomy;
using Kyocera.Ilsa.Models.DailyReports.Journeys.Security;

namespace Kyocera.Ilsa.Models.DailyReports.Journeys
{
    /// <summary>
    /// Defines the <see cref="JourneysViewModel" />.
    /// </summary>
    public class JourneysViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneysViewModel"/> class.
        /// </summary>
        public JourneysViewModel()
        {
            this.Cleaning = new CleaningViewModel();
            this.Security = new SecurityViewModel();
            this.Gastronomy = new GastronomyViewModel();
            this.Boarding = new BoardingViewModel();
        }

        /// <summary>
        /// Gets or sets the Journey.
        /// </summary>
        public string Journey { get; set; }

        /// <summary>
        /// Gets or sets the Cleaning.
        /// </summary>
        public CleaningViewModel Cleaning { get; set; }

        /// <summary>
        /// Gets or sets the Security.
        /// </summary>
        public SecurityViewModel Security { get; set; }

        /// <summary>
        /// Gets or sets the Gastronomy.
        /// </summary>
        public GastronomyViewModel Gastronomy { get; set; }

        /// <summary>
        /// Gets or sets the Boarding.
        /// </summary>
        public BoardingViewModel Boarding { get; set; }

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
            return !string.IsNullOrWhiteSpace(this.Journey) && this.Cleaning.IsValid() && this.Security.IsValid() && this.Gastronomy.IsValid() && this.Boarding.IsValid();
        }
    }
}

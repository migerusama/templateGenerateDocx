using System.Collections.Generic;
using Kyocera.Ilsa.Models.Common;

namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Boarding
{
    /// <summary>
    /// Defines the <see cref="BoardingViewModel" />.
    /// </summary>
    public class BoardingViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardingViewModel"/> class.
        /// </summary>
        public BoardingViewModel()
        {
            this.Opening = new EvaluationBoarding();
            this.Delay = new EvaluationBoarding();
            this.AdifAd = new EvaluationBoarding();
            this.Incident = new EvaluationBoarding();
        }

        /// <summary>
        /// Gets or sets the Opening.
        /// </summary>
        public EvaluationBoarding Opening { get; set; }

        /// <summary>
        /// Gets or sets the Delay.
        /// </summary>
        public EvaluationBoarding Delay { get; set; }

        /// <summary>
        /// Gets or sets the AdifAd.
        /// </summary>
        public EvaluationBoarding AdifAd { get; set; }

        /// <summary>
        /// Gets or sets the Incident.
        /// </summary>
        public EvaluationBoarding Incident { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            return this.Opening.IsValid()
                && this.Delay.IsValid()
                && this.AdifAd.IsValid()
                && this.Incident.IsValid();
        }

        /// <summary>
        /// The GetEvaluationGlobal.
        /// </summary>
        /// <returns>The <see cref="EnumerationEvaluationGlobal"/>.</returns>
        public EnumerationEvaluationGlobal GetEvaluationGlobal()
        {
            var evaluations = new List<EvaluationEnumeration>
            {
                this.Opening.Evaluation,
                this.Delay.Evaluation,
                this.AdifAd.Evaluation,
                this.Incident.Evaluation
            };

            return evaluations.TrueForAll(s => s == EvaluationEnumeration.OK) ? EnumerationEvaluationGlobal.OK : EnumerationEvaluationGlobal.NO_OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Kyocera.Ilsa.Models.DailyReports.Assistants;
using Kyocera.Ilsa.Models.DailyReports.Journeys;

namespace Kyocera.Ilsa.Models.DailyReports
{
    /// <summary>
    /// Defines the <see cref="DailyReport" />.
    /// </summary>
    public class DailyReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyReport"/> class.
        /// </summary>
        public DailyReport()
        {
            this.Assistants = new List<AssistantViewModel>();
            this.Journeys = new List<JourneysViewModel>();
        }

        /// <summary>
        /// Gets or sets the IdAssistant.
        /// </summary>
        [Required]
        public int IdAssistant { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Service.
        /// </summary>
        [Required]
        public int Service { get; set; }

        /// <summary>
        /// Gets or sets the Registration.
        /// </summary>
        [Required]
        public string Registration { get; set; }

        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the SaveTime.
        /// </summary>
        public DateTime SaveTime { get; set; }

        /// <summary>
        /// Gets or sets the Assistants.
        /// </summary>
        public List<AssistantViewModel> Assistants { get; set; }

        /// <summary>
        /// Gets or sets the Journeys.
        /// </summary>
        public List<JourneysViewModel> Journeys { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name)
                && this.IdAssistant > 0
                && !string.IsNullOrWhiteSpace(this.Registration)
                && this.Service > 0
                && (this.Assistants.Count > 0 && this.Assistants.TrueForAll(s => s.IsValid()))
                && (this.Journeys.Count > 0 && this.Journeys.TrueForAll(s => s.IsValid()));
        }
    }
}

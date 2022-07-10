using System.Collections.Generic;

namespace Kyocera.Ilsa.Models.Common
{
    /// <summary>
    /// Defines the <see cref="AssistantsJourneysListViewModel" />.
    /// </summary>
    public class AssistantsJourneysListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsJourneysListViewModel"/> class.
        /// </summary>
        public AssistantsJourneysListViewModel()
        {
            this.Assistants = new List<string>();
            this.Journeys = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsJourneysListViewModel"/> class.
        /// </summary>
        /// <param name="assistants">The assistants<see cref="List{string}"/>.</param>
        /// <param name="journeys">The journeys<see cref="List{string}"/>.</param>
        public AssistantsJourneysListViewModel(List<string> assistants, List<string> journeys)
        {
            this.Assistants = assistants;
            this.Journeys = journeys;
        }

        /// <summary>
        /// Gets or sets the Assistants.
        /// </summary>
        public List<string> Assistants { get; set; }

        /// <summary>
        /// Gets or sets the Journeys.
        /// </summary>
        public List<string> Journeys { get; set; }
    }
}

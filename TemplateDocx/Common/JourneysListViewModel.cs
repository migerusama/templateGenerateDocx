using System.Collections.Generic;

namespace Kyocera.Ilsa.Models.Common
{
    /// <summary>
    /// Defines the <see cref="JourneysListViewModel" />.
    /// </summary>
    public class JourneysListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneysListViewModel"/> class.
        /// </summary>
        public JourneysListViewModel()
        {
            this.Journeys = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneysListViewModel"/> class.
        /// </summary>
        /// <param name="journeys">The journeys<see cref="List{string}"/>.</param>
        public JourneysListViewModel(List<string> journeys)
        {
            this.Journeys = journeys;
        }

        /// <summary>
        /// Gets or sets the Journeys.
        /// </summary>
        public List<string> Journeys { get; set; }
    }
}

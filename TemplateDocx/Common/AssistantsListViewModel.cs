using System.Collections.Generic;

namespace Kyocera.Ilsa.Models.Common
{
    /// <summary>
    /// Defines the <see cref="AssistantsListViewModel" />.
    /// </summary>
    public class AssistantsListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsListViewModel"/> class.
        /// </summary>
        public AssistantsListViewModel()
        {
            this.Names = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsListViewModel"/> class.
        /// </summary>
        /// <param name="names">The names<see cref="List{string}"/>.</param>
        public AssistantsListViewModel(List<string> names)
        {
            this.Names = names;
        }

        /// <summary>
        /// Gets or sets the Names.
        /// </summary>
        public List<string> Names { get; set; }
    }
}

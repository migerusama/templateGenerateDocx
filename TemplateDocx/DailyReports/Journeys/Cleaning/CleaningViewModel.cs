using System.Collections.Generic;
using Kyocera.Ilsa.Models.Common;

namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Cleaning
{
    /// <summary>
    /// Defines the <see cref="CleaningViewModel" />.
    /// </summary>
    public class CleaningViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleaningViewModel"/> class.
        /// </summary>
        public CleaningViewModel()
        {
            this.Corridor = new EvaluationCleaning();
            this.Wc = new EvaluationCleaning();
            this.Armchair = new EvaluationCleaning();
            this.LuggageCarrier = new EvaluationCleaning();
            this.AssistantRoom = new EvaluationCleaning();
            this.Cafeteria = new EvaluationCleaning();
            this.Lobby = new EvaluationCleaning();
        }

        /// <summary>
        /// Gets or sets the Corridor.
        /// </summary>
        public EvaluationCleaning Corridor { get; set; }

        /// <summary>
        /// Gets or sets the Wc.
        /// </summary>
        public EvaluationCleaning Wc { get; set; }

        /// <summary>
        /// Gets or sets the Armchair.
        /// </summary>
        public EvaluationCleaning Armchair { get; set; }

        /// <summary>
        /// Gets or sets the LuggageCarrier.
        /// </summary>
        public EvaluationCleaning LuggageCarrier { get; set; }

        /// <summary>
        /// Gets or sets the AssistantRoom.
        /// </summary>
        public EvaluationCleaning AssistantRoom { get; set; }

        /// <summary>
        /// Gets or sets the Cafeteria.
        /// </summary>
        public EvaluationCleaning Cafeteria { get; set; }

        /// <summary>
        /// Gets or sets the Lobby.
        /// </summary>
        public EvaluationCleaning Lobby { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            return this.Corridor.IsValid()
                && this.Wc.IsValid()
                && this.Armchair.IsValid()
                && this.LuggageCarrier.IsValid()
                && this.AssistantRoom.IsValid()
                && this.Cafeteria.IsValid()
                && this.Lobby.IsValid();
        }

        /// <summary>
        /// The GetEvaluationGlobal.
        /// </summary>
        /// <returns>The <see cref="EnumerationEvaluationGlobal"/>.</returns>
        public EnumerationEvaluationGlobal GetEvaluationGlobal()
        {
            var evaluations = new List<EvaluationEnumeration>
            {
                this.Corridor.Evaluation,
                this.Wc.Evaluation,
                this.Armchair.Evaluation,
                this.LuggageCarrier.Evaluation,
                this.AssistantRoom.Evaluation,
                this.Cafeteria.Evaluation,
                this.Lobby.Evaluation
            };

            return evaluations.TrueForAll(s => s == EvaluationEnumeration.OK) ? EnumerationEvaluationGlobal.OK : EnumerationEvaluationGlobal.NO_OK;
        }
    }
}

using System.Collections.Generic;
using Kyocera.Ilsa.Models.Common;

namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Security
{
    /// <summary>
    /// Defines the <see cref="SecurityViewModel" />.
    /// </summary>
    public class SecurityViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityViewModel"/> class.
        /// </summary>
        public SecurityViewModel()
        {
            this.ApplyEvaluation = false;
            this.FireExtinguisher = new EvaluationSecurity();
            this.Flashlight = new EvaluationSecurity();
            this.Megaphone = new EvaluationSecurity();
            this.IntercomAndMegaphony = new EvaluationSecurity();
            this.ExteriorInteriorVisualInspection = new EvaluationSecurity();
            this.ExternalInfoScreen = new EvaluationSecurity();
            this.InternalInfoScreen = new EvaluationSecurity();
            this.Hammers = new EvaluationSecurity();
            this.EvacuationStairs = new EvaluationSecurity();
            this.FirstAidKit = new EvaluationSecurity();
            this.Defibrillator = new EvaluationSecurity();
        }

        /// <summary>
        /// Gets or sets the FireExtinguisher.
        /// </summary>
        public EvaluationSecurity FireExtinguisher { get; set; }

        /// <summary>
        /// Gets or sets the Flashlight.
        /// </summary>
        public EvaluationSecurity Flashlight { get; set; }

        /// <summary>
        /// Gets or sets the Megaphone.
        /// </summary>
        public EvaluationSecurity Megaphone { get; set; }

        /// <summary>
        /// Gets or sets the IntercomAndMegaphony.
        /// </summary>
        public EvaluationSecurity IntercomAndMegaphony { get; set; }

        /// <summary>
        /// Gets or sets the ExteriorInteriorVisualInspection.
        /// </summary>
        public EvaluationSecurity ExteriorInteriorVisualInspection { get; set; }

        /// <summary>
        /// Gets or sets the ExternalInfoScreen.
        /// </summary>
        public EvaluationSecurity ExternalInfoScreen { get; set; }

        /// <summary>
        /// Gets or sets the InternalInfoScreen.
        /// </summary>
        public EvaluationSecurity InternalInfoScreen { get; set; }

        /// <summary>
        /// Gets or sets the Hammers.
        /// </summary>
        public EvaluationSecurity Hammers { get; set; }

        /// <summary>
        /// Gets or sets the EvacuationStairs.
        /// </summary>
        public EvaluationSecurity EvacuationStairs { get; set; }

        /// <summary>
        /// Gets or sets the FirstAidKit.
        /// </summary>
        public EvaluationSecurity FirstAidKit { get; set; }

        /// <summary>
        /// Gets or sets the Defibrillator.
        /// </summary>
        public EvaluationSecurity Defibrillator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ApplyEvaluation.
        /// </summary>
        public bool ApplyEvaluation { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            return !this.ApplyEvaluation
                || (this.FireExtinguisher.IsValid()
                && this.Flashlight.IsValid()
                && this.Megaphone.IsValid()
                && this.IntercomAndMegaphony.IsValid()
                && this.ExteriorInteriorVisualInspection.IsValid()
                && this.ExternalInfoScreen.IsValid()
                && this.InternalInfoScreen.IsValid()
                && this.Hammers.IsValid()
                && this.EvacuationStairs.IsValid()
                && this.FirstAidKit.IsValid()
                && this.Defibrillator.IsValid());
        }

        /// <summary>
        /// The GetEvaluationGlobal.
        /// </summary>
        /// <returns>The <see cref="EnumerationEvaluationGlobal"/>.</returns>
        public EnumerationEvaluationGlobal GetEvaluationGlobal()
        {
            if (!this.ApplyEvaluation)
            {
                return EnumerationEvaluationGlobal.NO_EVALUATE;
            }

            var evaluations = new List<EvaluationEnumeration>
            {
                this.FireExtinguisher.Evaluation,
                this.Flashlight.Evaluation,
                this.Megaphone.Evaluation,
                this.IntercomAndMegaphony.Evaluation,
                this.ExteriorInteriorVisualInspection.Evaluation,
                this.ExternalInfoScreen.Evaluation,
                this.InternalInfoScreen.Evaluation,
                this.Hammers.Evaluation,
                this.EvacuationStairs.Evaluation,
                this.FirstAidKit.Evaluation,
                this.Defibrillator.Evaluation
            };

            return evaluations.TrueForAll(s => s == EvaluationEnumeration.OK) ? EnumerationEvaluationGlobal.OK : EnumerationEvaluationGlobal.NO_OK;
        }
    }
}

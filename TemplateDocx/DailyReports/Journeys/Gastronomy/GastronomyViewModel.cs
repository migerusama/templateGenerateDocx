using System.Collections.Generic;
using Kyocera.Ilsa.Models.Common;

namespace Kyocera.Ilsa.Models.DailyReports.Journeys.Gastronomy
{
    /// <summary>
    /// Defines the <see cref="GastronomyViewModel" />.
    /// </summary>
    public class GastronomyViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GastronomyViewModel"/> class.
        /// </summary>
        public GastronomyViewModel()
        {
            this.Butler = new EvaluationGastronomyButlerInfinitemealPreorder();
            this.InfiniteMeals = new EvaluationGastronomyButlerInfinitemealPreorder();
            this.PreOrder = new EvaluationGastronomyButlerInfinitemealPreorder();
            this.LogisticsCargo = new EvaluationGastronomyLogisticCargo();
            this.Cafeteria = new EvaluationGastronomyCafeteriaGategourmet();
            this.GategourmetService = new EvaluationGastronomyCafeteriaGategourmet();
            this.OnBoardSales = new EvaluationGastronomyOnBoardSale();
            this.Equipment = new EvaluationGastronomyEquipment();
        }

        /// <summary>
        /// Gets or sets the Butler.
        /// </summary>
        public EvaluationGastronomyButlerInfinitemealPreorder Butler { get; set; }

        /// <summary>
        /// Gets or sets the InfiniteMeals.
        /// </summary>
        public EvaluationGastronomyButlerInfinitemealPreorder InfiniteMeals { get; set; }

        /// <summary>
        /// Gets or sets the PreOrder.
        /// </summary>
        public EvaluationGastronomyButlerInfinitemealPreorder PreOrder { get; set; }

        /// <summary>
        /// Gets or sets the LogisticsCargo.
        /// </summary>
        public EvaluationGastronomyLogisticCargo LogisticsCargo { get; set; }

        /// <summary>
        /// Gets or sets the Cafeteria.
        /// </summary>
        public EvaluationGastronomyCafeteriaGategourmet Cafeteria { get; set; }

        /// <summary>
        /// Gets or sets the GategourmetService.
        /// </summary>
        public EvaluationGastronomyCafeteriaGategourmet GategourmetService { get; set; }

        /// <summary>
        /// Gets or sets the OnBoardSales.
        /// </summary>
        public EvaluationGastronomyOnBoardSale OnBoardSales { get; set; }

        /// <summary>
        /// Gets or sets the Equipment.
        /// </summary>
        public EvaluationGastronomyEquipment Equipment { get; set; }

        /// <summary>
        /// The IsValid.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool IsValid()
        {
            return this.Butler.IsValid()
                && this.InfiniteMeals.IsValid()
                && this.PreOrder.IsValid()
                && this.LogisticsCargo.IsValid()
                && this.Cafeteria.IsValid()
                && this.GategourmetService.IsValid()
                && this.OnBoardSales.IsValid()
                && this.Equipment.IsValid();
        }

        /// <summary>
        /// The GetEvaluationGlobal.
        /// </summary>
        /// <returns>The <see cref="EnumerationEvaluationGlobal"/>.</returns>
        public EnumerationEvaluationGlobal GetEvaluationGlobal()
        {
            var evaluations = new List<EvaluationEnumeration>
            {
                this.Butler.Evaluation,
                this.InfiniteMeals.Evaluation,
                this.PreOrder.Evaluation,
                this.LogisticsCargo.Evaluation,
                this.Cafeteria.Evaluation,
                this.GategourmetService.Evaluation,
                this.OnBoardSales.Evaluation,
                this.Equipment.Evaluation
            };

            return evaluations.TrueForAll(s => s == EvaluationEnumeration.OK) ? EnumerationEvaluationGlobal.OK : EnumerationEvaluationGlobal.NO_OK;
        }
    }
}

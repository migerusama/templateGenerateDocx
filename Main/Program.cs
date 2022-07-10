namespace Main
{
    using Kyocera.Ilsa.Models.DailyReports;
    using Kyocera.Ilsa.Models.DailyReports.Journeys;
    using Kyocera.Ilsa.Models.DailyReports.Journeys.Cleaning;
    using TemplateDocx;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            CleaningViewModel cleaning = new CleaningViewModel();
            cleaning.Cafeteria.Evaluation = EvaluationEnumeration.NO_OK;
            cleaning.Cafeteria.Comment = " aoksdoaksdafhad asd asd asd oaf";
            cleaning.Cafeteria.Classification = ClassificationEnumeration.Broke;
            cleaning.Cafeteria.NumTrain = "123123";
            JourneysViewModel journey = new JourneysViewModel();
            journey.Cleaning = cleaning;
            DailyReport report = new DailyReport();
            report.Journeys.Add(journey);


            TemplateDocxService template = new TemplateDocxService();

            template.ProcessTemplate(new byte[1], report);
        }
    }
}

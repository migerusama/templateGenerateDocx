namespace TemplateDocx
{
    using System.IO;
    using Kyocera.Ilsa.Models.DailyReports;
    using Kyocera.Ilsa.Models.DailyReports.Journeys.Gastronomy;
    using TemplateEngine.Docx;

    public class TemplateDocxService
    {
        public void ProcessTemplate(byte[] template, DailyReport report)
        {
            File.Delete("OutputDocument.docx");
            File.Copy("InputTemplate.docx", "OutputDocument.docx");

            var templateFill = new Content(
                new FieldContent("Report date", report.Date.ToShortDateString()),
                new FieldContent("Company name", "Ilsa"),
                new ImageContent("Logo", File.ReadAllBytes("Logo.jpg")));

            var list = new ListContent("List assistant");

            var question = new TableContent("Row question")
                            .AddRow(
                                new FieldContent("Question", "1"),
                                new FieldContent("Evaluation", "2"),
                                new FieldContent("Observation question", "3"))
                            .AddRow(
                                new FieldContent("Question", "1"),
                                new FieldContent("Evaluation", "2"),
                                new FieldContent("Observation question", "3"));
            list.AddItem(
                    new FieldContent("Name", "Asistente1"),
                    question,
                    new FieldContent("Observation", "asd asd asd as da sd asd asd "));

            question = new TableContent("Row question")
                            .AddRow(
                                new FieldContent("Question", "10"),
                                new FieldContent("Evaluation", "20"),
                                new FieldContent("Observation question", "30"))
                            .AddRow(
                                new FieldContent("Question", "1"),
                                new FieldContent("Evaluation", "2"),
                                new FieldContent("Observation question", "3"));
            list.AddItem(
                    new FieldContent("Name", "Asistente10"),
                    question,
                    new FieldContent("Observation", "asd asd asd as da sd asd asd "));

            templateFill.Lists.Add(list);

            var ListJourney = new RepeatContent("Repeat")
                        .AddItem(
                            new FieldContent("Journey", "Viaje1"),
                            new TableContent("Row cleaning")
                                .AddRow(
                                    new FieldContent("Evaluation name", "Pasillos"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Corridor.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Corridor.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Corridor.Comment))
                                .AddRow(
                                    new FieldContent("Evaluation name", "WC"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Wc.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Wc.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Wc.Comment))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Butacas"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Armchair.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Armchair.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Armchair.Comment))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Porta equipajes"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.LuggageCarrier.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.LuggageCarrier.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.LuggageCarrier.Comment))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Sala asistente"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.AssistantRoom.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.AssistantRoom.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.AssistantRoom.Comment))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Cafetería"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Cafeteria.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Cafeteria.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Cafeteria.Comment))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Vestíbulo"),
                                    new FieldContent("Evaluation", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Num train", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Lobby.NumTrain),
                                    new FieldContent("Classification", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Lobby.Classification.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Lobby.Comment)),
                            new TableContent("Row gastronomy")
                                .AddRow(
                                    new FieldContent("Evaluation name", "Mayordomía"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Butler.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.Butler.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Butler.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.Butler.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Butler.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Comidas infinitas"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.InfiniteMeals.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.InfiniteMeals.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.InfiniteMeals.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.InfiniteMeals.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.InfiniteMeals.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Pre-Order"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.PreOrder.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.PreOrder.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.PreOrder.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.PreOrder.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.PreOrder.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Carga logística"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.LogisticsCargo.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.LogisticsCargo.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.LogisticsCargo.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.LogisticsCargo.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.LogisticsCargo.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Cafetería"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Cafeteria.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Cafeteria.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Cafeteria.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Servicio Gategourmet"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.GategourmetService.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.GategourmetService.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.GategourmetService.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.GategourmetService.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.GategourmetService.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Venta a bordo"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.OnBoardSales.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.OnBoardSales.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.OnBoardSales.Detail.ToString()),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.OnBoardSales.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.OnBoardSales.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Equipamiento"),
                                    new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Detail", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Observations),
                                    new FieldContent("Observation", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Observations)),
                            new TableContent("Row boarding")
                                .AddRow(
                                    new FieldContent("Evaluation name", "Apertura"),
                                    new FieldContent("Evaluation", report.Journeys[0].Boarding.Opening.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Observation", report.Journeys[0].Boarding.Opening.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.Opening.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Retraso"),
                                    new FieldContent("Evaluation", report.Journeys[0].Boarding.Delay.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Observation", report.Journeys[0].Boarding.Delay.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.Delay.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Anuncio ADIF"),
                                    new FieldContent("Evaluation", report.Journeys[0].Boarding.AdifAd.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Observation", report.Journeys[0].Boarding.AdifAd.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.AdifAd.Observations))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Incidencia"),
                                    new FieldContent("Evaluation", report.Journeys[0].Boarding.Incident.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                                    new FieldContent("Observation", report.Journeys[0].Boarding.Incident.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.Incident.Observations)),
                            new TableContent("Row security")
                                .AddRow(
                                    new FieldContent("Evaluation name", "Extintor"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Linterna"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Megáfono"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Interfonía y Megafonía"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Inspección visual exterior/interior"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Pantalla info exterior"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Pantalla info interior"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Martillos"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Escaleras de evacuación"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Botiquín"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " "))
                                .AddRow(
                                    new FieldContent("Evaluation name", "Desfibrilador"),
                                    new FieldContent("Evaluation", "NO EVALUADO"),
                                    new FieldContent("Num train", " "),
                                    new FieldContent("Observation", " ")),
                        new FieldContent("Observation global", "asd asd as das"));

            /*var cleaningTable = new TableContent("Row cleaning")
                    .AddRow(
                        new FieldContent("Evaluation name", "Pasillos"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Corridor.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Corridor.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.Corridor.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Corridor.Comment))
                    .AddRow(
                        new FieldContent("Evaluation name", "WC"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Wc.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Wc.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.Wc.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Wc.Comment))
                    .AddRow(
                        new FieldContent("Evaluation name", "Butacas"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Armchair.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Armchair.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.Armchair.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Armchair.Comment))
                    .AddRow(
                        new FieldContent("Evaluation name", "Porta equipajes"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.LuggageCarrier.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.LuggageCarrier.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.LuggageCarrier.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.LuggageCarrier.Comment))
                    .AddRow(
                        new FieldContent("Evaluation name", "Sala asistente"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.AssistantRoom.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.AssistantRoom.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.AssistantRoom.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.AssistantRoom.Comment))
                    .AddRow(
                        new FieldContent("Evaluation name", "Cafetería"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Cafeteria.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Cafeteria.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Cafeteria.Comment))
                    .AddRow(
                        new FieldContent("Evaluation name", "Vestíbulo"),
                        new FieldContent("Evaluation", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Lobby.NumTrain),
                        new FieldContent("Classification", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Lobby.Classification.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Cleaning.Lobby.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Cleaning.Lobby.Comment));


            var gastronomyTable = new TableContent("Gastronomy table")
                    .AddRow(
                        new FieldContent("Evaluation name", "Mayordomía"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Butler.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.Butler.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Butler.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.Butler.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Butler.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Comidas infinitas"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.InfiniteMeals.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.InfiniteMeals.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.InfiniteMeals.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.InfiniteMeals.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.InfiniteMeals.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Pre-Order"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.PreOrder.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.PreOrder.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.PreOrder.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.PreOrder.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.PreOrder.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Carga logística"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.LogisticsCargo.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.LogisticsCargo.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.LogisticsCargo.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.LogisticsCargo.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.LogisticsCargo.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Cafetería"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Cafeteria.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Cafeteria.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.Cafeteria.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Cafeteria.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Servicio Gategourmet"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.GategourmetService.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.GategourmetService.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.GategourmetService.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.GategourmetService.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.GategourmetService.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Venta a bordo"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.OnBoardSales.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.OnBoardSales.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.OnBoardSales.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.OnBoardSales.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.OnBoardSales.Observations));

            if (report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.NO_OK & (report.Journeys[0].Gastronomy.Equipment.Detail == DetailEquipmentEnumeration.Full_Trolly | report.Journeys[0].Gastronomy.Equipment.Detail == DetailEquipmentEnumeration.Half_Trolly | report.Journeys[0].Gastronomy.Equipment.Detail == DetailEquipmentEnumeration.Waste_Trolly))
            {
                gastronomyTable = new TableContent("RowEquipement")
                    .AddRow(
                        new FieldContent("Evaluation name", "Equipamiento"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Detail.ToString()),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Observations),
                        new FieldContent("Trolly number", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Trolly.TrollyNumber),
                        new FieldContent("Detail trolly", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Trolly.Detail.ToString()),
                        new FieldContent("Obs trolly", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Trolly.Observation));
            }
            else
            {
                gastronomyTable.AddRow(
                        new FieldContent("Evaluation name", "Equipamiento"),
                        new FieldContent("Evaluation", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Detail", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Observations),
                        new FieldContent("Observation", report.Journeys[0].Gastronomy.Equipment.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Gastronomy.Equipment.Observations));
            }

            var boardingTable = new TableContent("Boarding table")
                    .AddRow(
                        new FieldContent("Evaluation name", "Apertura"),
                        new FieldContent("Evaluation", report.Journeys[0].Boarding.Opening.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Observation", report.Journeys[0].Boarding.Opening.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.Opening.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Retraso"),
                        new FieldContent("Evaluation", report.Journeys[0].Boarding.Delay.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Observation", report.Journeys[0].Boarding.Delay.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.Delay.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Anuncio ADIF"),
                        new FieldContent("Evaluation", report.Journeys[0].Boarding.AdifAd.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Observation", report.Journeys[0].Boarding.AdifAd.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.AdifAd.Observations))
                    .AddRow(
                        new FieldContent("Evaluation name", "Incidencia"),
                        new FieldContent("Evaluation", report.Journeys[0].Boarding.Incident.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Observation", report.Journeys[0].Boarding.Incident.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Boarding.Incident.Observations));


            var securityTable = new TableContent("Security table");
            if (report.Journeys[0].Security.ApplyEvaluation)
            {
                securityTable
                    .AddRow(
                        new FieldContent("Evaluation name", "Extintor"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.FireExtinguisher.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.FireExtinguisher.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.FireExtinguisher.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.FireExtinguisher.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.FireExtinguisher.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Linterna"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.Flashlight.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.Flashlight.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Flashlight.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.Flashlight.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Flashlight.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Megáfono"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.Megaphone.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.Megaphone.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Megaphone.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.Megaphone.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Megaphone.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Interfonía y Megafonía"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.IntercomAndMegaphony.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.IntercomAndMegaphony.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.IntercomAndMegaphony.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.IntercomAndMegaphony.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.IntercomAndMegaphony.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Inspección visual exterior/interior"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.ExteriorInteriorVisualInspection.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.ExteriorInteriorVisualInspection.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.ExteriorInteriorVisualInspection.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.ExteriorInteriorVisualInspection.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.ExteriorInteriorVisualInspection.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Pantalla info exterior"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.ExternalInfoScreen.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.ExternalInfoScreen.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.ExternalInfoScreen.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.ExternalInfoScreen.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.ExternalInfoScreen.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Pantalla info interior"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.InternalInfoScreen.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.InternalInfoScreen.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.InternalInfoScreen.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.InternalInfoScreen.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.InternalInfoScreen.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Martillos"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.Hammers.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.Hammers.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Hammers.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.Hammers.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Hammers.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Escaleras de evacuación"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.EvacuationStairs.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.EvacuationStairs.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.EvacuationStairs.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.EvacuationStairs.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.EvacuationStairs.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Botiquín "),
                        new FieldContent("Evaluation", report.Journeys[0].Security.FirstAidKit.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.FirstAidKit.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.FirstAidKit.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.FirstAidKit.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.FirstAidKit.Observation))
                    .AddRow(
                        new FieldContent("Evaluation name", "Desfibrilador"),
                        new FieldContent("Evaluation", report.Journeys[0].Security.Defibrillator.Evaluation == EvaluationEnumeration.OK ? "OK" : "NO OK"),
                        new FieldContent("Num train", report.Journeys[0].Security.Defibrillator.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Defibrillator.NumTrain),
                        new FieldContent("Observation", report.Journeys[0].Security.Defibrillator.Evaluation == EvaluationEnumeration.OK ? " " : report.Journeys[0].Security.Defibrillator.Observation));
            }
            else
            {
                securityTable
                    .AddRow(
                        new FieldContent("Evaluation name", "Extintor"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Linterna"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Megáfono"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Interfonía y Megafonía"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Inspección visual exterior/interior"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Pantalla info exterior"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Pantalla info interior"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Martillos"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Escaleras de evacuación"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Botiquín"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "))
                    .AddRow(
                        new FieldContent("Evaluation name", "Desfibrilador"),
                        new FieldContent("Evaluation", "NO EVALUADO"),
                        new FieldContent("Num train", " "),
                        new FieldContent("Observation", " "));
            }

            ListJourney.AddItem(new FieldContent("Journey", "Viaje1"), cleaningTable, gastronomyTable, boardingTable, securityTable);*/

            templateFill.Repeats.Add(ListJourney);

            using (var outputDocument = new TemplateProcessor("OutputDocument.docx")
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(templateFill);
                outputDocument.SaveChanges();
            }
        }
    }
}

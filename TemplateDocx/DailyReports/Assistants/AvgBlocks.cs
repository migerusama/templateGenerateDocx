namespace Kyocera.Ilsa.Models.DailyReports.Assistants
{
    /// <summary>
    /// Defines the <see cref="AvgBlocks" />.
    /// </summary>
    public class AvgBlocks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvgBlocks"/> class.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <param name="average">The average<see cref="double"/>.</param>
        public AvgBlocks(int id, double average)
        {
            this.Id = id;
            this.Average = average;
        }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Average.
        /// </summary>
        public double Average { get; set; }
    }
}

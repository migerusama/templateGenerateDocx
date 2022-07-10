namespace Kyocera.Ilsa.Models.Configurations
{
    /// <summary>
    /// Defines the <see cref="ConfigurationTenant" />.
    /// </summary>
    public class ConfigurationTenant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationTenant"/> class.
        /// </summary>
        /// <param name="url">The url<see cref="string"/>.</param>
        public ConfigurationTenant(string url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public string Url { get; set; }
    }
}

namespace Kyocera.Ilsa.Reads.Contracts.ViewModels.Configurations
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Blocks" />.
    /// </summary>
    public class Blocks
    {
        /// <summary>
        /// Gets or sets the IdBlock.
        /// </summary>
        public int IdBlock { get; set; }

        /// <summary>
        /// Gets or sets the MetadataFilecontainerIdBlock.
        /// </summary>
        public int MetadataFilecontainerIdBlock { get; set; }

        /// <summary>
        /// Gets or sets the NameBlock.
        /// </summary>
        public string NameBlock { get; set; }

        /// <summary>
        /// Gets or sets the Questions.
        /// </summary>
        public List<Questions> Questions { get; set; }
    }
}
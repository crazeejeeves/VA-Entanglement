
namespace entanglement.Core.Data
{
    /// <summary>
    /// Loaded binding information
    /// </summary>
    public class ActionKey
    {
        /// <summary>
        /// Unique command or action name
        /// </summary>
        public string CommandName { get; set; }

        /// <summary>
        /// Application-specific key bind. Primary slot.
        /// </summary>
        public string Primary { get; set; }

        /// <summary>
        /// Application-specific key bind. Secondary slot, if supported by the application.
        /// </summary>
        public string Secondary { get; set; }
    }
}

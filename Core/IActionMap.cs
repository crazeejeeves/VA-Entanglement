using entanglement.Core.Data;

namespace entanglement.Core
{
    /// <summary>
    /// Interface for storing and translating the loaded actions into the relevant
    /// Voice Attack variables
    /// </summary>
    public interface IActionMap
    {
        /// <summary>
        /// Register an action
        /// </summary>
        /// <param name="action">Action information</param>
        void AddActionKey(ActionKey action);

        /// <summary>
        /// Checks if the action key information for the specified command name exists
        /// </summary>
        /// <param name="commandName">Command to check</param>
        /// <returns>True if the command exists</returns>
        bool ActionKeyExists(string commandName);
    }
}

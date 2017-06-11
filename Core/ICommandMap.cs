
namespace entanglement.Core
{
    /// <summary>
    /// Interface for obtainind the command mapping from a specified source file.
    /// 
    /// Command maps are used as a meta-layer to address the following concerns:
    /// a. Different applications use a different naming convention for representing command names
    /// b. Commands in the file may not match commands in the UI; can be jarring for new users
    /// c. Not all commands need to be binded to VoiceAttack
    /// </summary>
    public interface ICommandMap
    {
        /// <summary>
        /// Load a command map data file
        /// </summary>
        /// <param name="mapPath">Path to the command path XML file</param>
        void Load(string mapPath);

        /// <summary>
        /// Checks if the specified command name exists in the command map
        /// </summary>
        /// <param name="commandName">Command to check</param>
        /// <returns>True if the command exists. False may indicate a map mismatch or a new command 
        /// has been introduced but not mapped</returns>
        bool CommandExists(string commandName);

        /// <summary>
        /// Request for the friendly name (if any) of a specified command. By default, this is the
        /// same as the commandName but can be customized by the developer. E.g.
        /// In Elite:Dangerous, the 'Engine Boost' command in UI is defined as 'UseBoostJuice'. A friendly
        /// name can be used to override this to 'EngineBoost' to make the variable more intuitive when
        /// exported to VoiceAttack
        /// </summary>
        /// <param name="commandName"></param>
        /// <returns></returns>
        string GetFriendlyName(string commandName);
    }
}

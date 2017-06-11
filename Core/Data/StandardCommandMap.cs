
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;


namespace entanglement.Core.Data
{
    /// <summary>
    /// Provides standard command map loading and manipulation
    /// </summary>
    public class StandardCommandMap : ICommandMap
    {
        private IDictionary<string, Command> _included;
        private IDictionary<string, Command> _excluded;

        public StandardCommandMap()
        {
            _included = new Dictionary<string, Command>();
            _excluded = new Dictionary<string, Command>();
        }

        /// <summary>
        /// Register a command. Overwrites existing items
        /// </summary>
        /// <param name="name">Command name</param>
        /// <param name="include">Inclusion flag</param>
        /// <param name="friendlyName">Friendly command name</param>
        protected void AddCommand(string name, bool include, string friendlyName)
        {
            Command command = new Command(name, include, friendlyName);
            AddCommand(command);
        }

        /// <summary>
        /// Register a command. Overwrites existing items
        /// </summary>
        /// <param name="command">Pre-created Command object</param>
        protected void AddCommand(Command command)
        {
            if (CommandExists(command.Name))
            {
                _included.Remove(command.Name);
            }
            if(_excluded.ContainsKey(command.Name))
            {
                _excluded.Remove(command.Name);
            }

            if (command.Include)
            {
                _included.Add(command.Name, command);
            }
            else
            {
                _excluded.Add(command.Name, command);
            }
        }

        #region Interface implementations

        public void Load(string mapPath)
        {
            XDocument doc = XDocument.Load(mapPath);

            var result = doc.Descendants("Command").Where(c => c.Element("SourceName") != null)
                .Select(c =>
                   new Command(
                       c.Element("SourceName")?.Value,
                       Convert.ToBoolean(c.Attribute("Include")?.Value ?? "true"),
                       c.Element("FriendlyName")?.Value ?? c.Element("SourceName").Value
                       ));

            foreach (Command c in result)
            {
                AddCommand(c);
            }
        }

        public bool CommandExists(string commandName)
        {
            return _included.ContainsKey(commandName);
        }

        public string GetFriendlyName(string commandName)
        {
            if (CommandExists(commandName))
            {
                Command c = _included[commandName];
                return c.FriendlyName;
            }

            throw new KeyNotFoundException("Requested command '{0}' does not exist");
        }

        #endregion
    }
}

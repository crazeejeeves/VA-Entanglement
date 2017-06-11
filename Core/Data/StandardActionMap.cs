using System.Collections.Generic;


namespace entanglement.Core.Data
{
    /// <summary>
    /// Provides standard action map manipulation services
    /// </summary>
    public class StandardActionMap : IActionMap
    {
        private IDictionary<string, ActionKey> _actions;

        public StandardActionMap()
        {
            _actions = new Dictionary<string, ActionKey>();
        }

        #region Interface implementation

        public void AddActionKey(ActionKey action)
        {
            if(_actions.ContainsKey(action.CommandName))
            {
                _actions.Remove(action.CommandName);
            }
            _actions.Add(action.CommandName, action);
        }

        public bool ActionKeyExists(string commandName)
        {
            return _actions.ContainsKey(commandName);
        }

        #endregion
    }
}

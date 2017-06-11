using System.Linq;
using System.Xml.Linq;
using System.Diagnostics;

using entanglement.Core;
using entanglement.Core.Commands;
using System;
using System.Collections.Generic;

namespace entanglement.Plugin.App.Elite
{
    public class EliteBindingReader: IBindingReader
    {
        private ICommandMap _commandMap;
        private IKeyMap _keyMap;
        private readonly string MAP_FILENAME = @"Commands\commandmap.Elite.xml";


        public EliteBindingReader()
        {
        }

        public void Configure(ICommandMap commandMap, IKeyMap keyMap)
        {
            Debug.Assert(commandMap != null);
            Debug.Assert(keyMap != null);

            _commandMap = commandMap;
            _keyMap = keyMap;
        }

        public void Load(string path)
        {
            Debug.Assert(_commandMap != null);
            Debug.Assert(_keyMap != null);

            _commandMap.Load(MAP_FILENAME);
            var bindings = _LoadBindings(path);
            _ProcessBindings(bindings);
        }

        private IEnumerable<ActionKey> _LoadBindings(string srcPath)
        {
            XDocument doc = XDocument.Load(srcPath);

            var result = doc.Descendants().Where(c => c.Element("Primary") != null)
                .Select(c =>
                    new ActionKey
                    {
                        CommandName = c.Name.ToString(),
                        Primary = c.Element("Primary")?.Attribute("Key")?.Value ?? "Unknown",
                        Secondary = c.Element("Secondary")?.Attribute("Key")?.Value ?? "Unknown"
                    }
                );

            return result.ToList();
        }

        private void _ProcessBindings(IEnumerable<ActionKey> bindings)
        {
            IList<ActionKey> temp = new List<ActionKey>();

            foreach(var action in bindings)
            {
                if(_commandMap.CommandExists(action.CommandName))
                {
                    // TODO: Track key binding
                    temp.Add(action);
                }
            }

            Debug.WriteLine("Processing complete");
        }
    }
}

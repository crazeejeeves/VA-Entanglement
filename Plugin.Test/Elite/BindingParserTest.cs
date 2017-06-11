using Xunit;

using entanglement.Core;
using entanglement.Core.Data;
using entanglement.Plugin.App.Elite;


namespace Plugin.Test.Elite
{
    public class BindingParserTest
    {
        [Fact]
        public void ParseEliteBindingFile()
        {
            ICommandMap commandMap = new StandardCommandMap();
            IActionMap actionMap = new StandardActionMap();


            EliteBindingReader reader = new EliteBindingReader();
            reader.Configure(commandMap, actionMap);
            reader.Load(@"X:\Documents\Sources\ref.binds");
        }
    }
}

using entanglement.Plugin.App.Elite;
using Xunit;


namespace Plugin.Test.Elite
{
    public class BindingParserTest
    {
        [Fact]
        public void ParseEliteBindingFile()
        {
            BindingParser bp = new BindingParser();
            bp.ProcessSource(@"X:\Documents\Sources\ref.binds");
        }
    }
}

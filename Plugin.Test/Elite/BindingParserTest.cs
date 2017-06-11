using Xunit;
using Moq;

using entanglement.Core;
using entanglement.Core.Commands;
using entanglement.Plugin.App.Elite;


namespace Plugin.Test.Elite
{
    public class BindingParserTest
    {
        [Fact]
        public void ParseEliteBindingFile()
        {
            StandardCommandMap scm = new StandardCommandMap();

            var mock = new Mock<IKeyMap>();
            IKeyMap km = mock.Object;


            EliteBindingReader reader = new EliteBindingReader();
            reader.Configure(scm, km);
            reader.Load(@"X:\Documents\Sources\ref.binds");
        }
    }
}

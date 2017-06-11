using Xunit;

using entanglement.Core.Data;


namespace Core.Test.Commands
{
    public class StandardCommandMapTest
    {
        [Fact]
        public void LoadCommandMapSuccessfullyIfContentsAreCompliant()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");
        }

        [Fact]
        public void SkipsCommandIfMissingSourceName()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Broken.xml");
        }

        [Fact]
        public void AllIncludedCommandsExist()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");

            Assert.True(cm.CommandExists("IncludedCommand"));
            Assert.True(cm.CommandExists("CommandWithMissingFriendly"));
            Assert.True(cm.CommandExists("CommandWithMissingInclude"));
            Assert.True(cm.CommandExists("CommandWithNonstandardFriendly"));
        }

        [Fact]
        public void DefinedFriendlyNamesAreAvailable()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");

            Assert.Equal("FriendlyIncludedCommand", cm.GetFriendlyName("IncludedCommand"));
            Assert.Equal("FriendlyCommandWithMissingInclude", cm.GetFriendlyName("CommandWithMissingInclude"));
        }

        [Fact]
        public void WhitespacesInFriendlyNameAreTrimmed()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");

            Assert.Equal("FriendlyNameWithWhitespaces", cm.GetFriendlyName("CommandWithNonstandardFriendly"));
        }

        [Fact]
        public void DefaultFriendlyNamesIfUnspecified()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");

            Assert.Equal("CommandWithMissingFriendly", cm.GetFriendlyName("CommandWithMissingFriendly"));
        }

        [Fact]
        public void AllExcludedCommandsDoNotExist()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");

            Assert.False(cm.CommandExists("ExcludedCommand"));
        }

        [Fact]
        public void UndefinedCommandsDoNotExist()
        {
            StandardCommandMap cm = new StandardCommandMap();
            cm.Load(@"Commands\commandmap.Simple.xml");

            Assert.False(cm.CommandExists("MiscellaneousCommand"));
        }
    }
}

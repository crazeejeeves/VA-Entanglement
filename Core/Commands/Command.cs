
namespace entanglement.Core.Commands
{
    public class Command
    {
        public string Name;
        public string FriendlyName;
        public bool Include;

        public Command(string name, bool include, string friendlyName = null)
        {
            Name = name;
            Include = include;
            FriendlyName = friendlyName ?? name;
        }
    }
}

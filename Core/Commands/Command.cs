using entanglement.Core.Utils;

namespace entanglement.Core.Commands
{
    public class Command
    {
        public string Name { get; set; }
        public bool Include { get; set; }

        private string _friendlyName;
        public string FriendlyName
        {
            get => _friendlyName;

            set => _friendlyName = value.RemoveWhitespace();
        }
        

        public Command(string name, bool include, string friendlyName = null)
        {
            Name = name;
            Include = include;
            FriendlyName = friendlyName ?? name;
        }
    }
}

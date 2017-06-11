namespace entanglement.Core
{
    public interface IBindingReader
    {
        void Configure(ICommandMap commandMap, IKeyMap keyMap);
        void Load(string path);
    }
}

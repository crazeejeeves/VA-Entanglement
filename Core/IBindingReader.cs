namespace entanglement.Core
{
    public interface IBindingReader
    {
        void Configure(ICommandMap commandMap, IActionMap actionMap);
        void Load(string path);
    }
}

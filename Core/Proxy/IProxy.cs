using System;
using System.Collections.Generic;


namespace entanglement.Core.Proxy
{
    using ObjectDictionary = Dictionary<string, object>;

    public interface IProxy
    {
        string GetProfileName();
        string PluginPath();

        string Context { get; }
        ObjectDictionary SessionState { get; }

        int? GetInt(string name);
        void SetInt(string name, int? value);

        short? GetSmallInt(string name);
        void SetSmallInt(string name, short? value);

        string GetText(string name);
        void SetText(string name, string value);

        decimal? GetDecimal(string name);
        void SetDecimal(string name, decimal? value);

        bool? GetBoolean(string name);
        void SetBoolean(string name, bool? value);

        DateTime? GetDate(string name);
        void SetDate(string name, DateTime? value);

        bool CommandExists(string name);
        void ExecuteCommand(string commandName, bool waitForReturn = false);
        string ParseTokens(string tokenName);

        bool Stopped { get;  }
        void ResetStopFlag();

        void WriteToLog(string message, string color);
    }
}

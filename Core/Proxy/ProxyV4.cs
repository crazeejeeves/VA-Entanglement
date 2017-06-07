using System;
using System.Collections.Generic;


namespace entanglement.Core.Proxy
{
    internal class ProxyV4: IProxy
    {
        private dynamic _proxy;

        protected dynamic Proxy
        {
            get { return _proxy; }
            set { _proxy = value; }
        }

        public ProxyV4(dynamic vaProxy)
        {
            this.Proxy = vaProxy;
        }


        public string GetProfileName()
        {
            return Proxy.GetProfileName();
        }

        public string PluginPath()
        {
            return Proxy.PluginPath();
        }


        public string Context
        {
            get { return Proxy.Context; }
        }

        public Dictionary<string, object> SessionState
        {
            get { return Proxy.SessionState; }
        }
        
        
        public int? GetInt(string name)
        {
            return Proxy.GetInt(name);
        }

        public void SetInt(string name, int? value)
        {
            Proxy.SetInt(name, value);
        }

        public short? GetSmallInt(string name)
        {
            return Proxy.GetSmallInt(name);
        }

        public void SetSmallInt(string name, short? value)
        {
            Proxy.SetSmallInt(name, value);
        }

        public string GetText(string name)
        {
            return Proxy.GetText(name);
        }

        public void SetText(string name, string value)
        {
            Proxy.SetText(name, value);
        }
        
        public decimal? GetDecimal(string name)
        {
            return Proxy.GetDecimal(name);
        }

        public void SetDecimal(string name, decimal? value)
        {
            Proxy.SetDecimal(name, value);
        }

        public bool? GetBoolean(string name)
        {
            return Proxy.GetBoolean(name);
        }

        public void SetBoolean(string name, bool? value)
        {
            Proxy.SetBoolean(name, value);
        }

        public DateTime? GetDate(string name)
        {
            return Proxy.GetDate(name);
        }

        public void SetDate(string name, DateTime? value)
        {
            Proxy.SetDate(name, value);
        }


        public bool CommandExists(string name)
        {
            return Proxy.CommandExists(name);
        }

        public void ExecuteCommand(string commandName, bool waitForReturn = false)
        {
            Proxy.ExecuteCommand(commandName, waitForReturn);
        }

        public string ParseTokens(string tokenName)
        {
            return Proxy.ParseTokens(tokenName);
        }


        public bool Stopped
        {
            get { return Proxy.Stopped; }
        }

        public void ResetStopFlag()
        {
            Proxy.ResetStopFlag();
        }


        public void WriteToLog(string message, string color)
        {
            // TODO: Replace string color with API-specific strong type alternative
            Proxy.WriteToLog(message, color);
        }
    }
}

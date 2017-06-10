using System;
using entanglement.Core.Proxy;

namespace entanglement.Plugin
{
    public class Entangle
    {
        public static string VA_DisplayName()
        {
            return "entanglement v0.1.0";
        }

        public static string VA_DisplayInfo()
        {
            return "Entanglement, Key-binding extractor for VoiceAttack";
        }

        public static Guid VA_Id()
        {
            return new Guid("73078BC6-D9B1-41CA-82A7-B50A2C72F4BF");
        }

        public static void VA_Init1(dynamic vaProxy)
        {
            // TODO: Initialize here
        }

        public static void VA_Exit1(dynamic vaProxy)
        {
            // TODO: Cleanup here
        }

        public static void VA_Invoke1(dynamic vaProxy)
        {
            IProxyHelper proxy = ProxyHelperFactory.GetProxy(vaProxy);

            proxy.WriteToLog("Some magic is happening", "blue");
            proxy.WriteToLog(proxy.PluginPath(), "blue");

        }

        public static void VA_StopCommand()
        {
            // TODO: Stop all processing, if applicable
        }
    }
}

using System;
using System.Diagnostics;


namespace entanglement.Core.Proxy
{
    public class ApiInfo
    {
        private dynamic _proxy;

        public ApiInfo(dynamic vaProxy)
        {
            _proxy = vaProxy;
        }

        internal dynamic Proxy
        {
            get
            {
                return _proxy;
            }
        }

        public Version ProxyVersion
        {
            get
            {
                return _proxy.ProxyVersion;
            }
        }


        public Version VAVersion
        {
            get
            {
                return _proxy.VAVersion;
            }
        }
    }
}

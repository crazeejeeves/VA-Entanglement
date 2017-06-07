using System;

namespace entanglement.Core.Proxy
{
    public static class ProxyHelperFactory
    {
        public static IProxyHelper GetProxy(dynamic vaProxy)
        {
            ApiInfo apiInfo = new ApiInfo(vaProxy);
            string proxyVersion = apiInfo.ProxyVersion.ToString();

            // TODO: Replace with an abstraction to decouple factory from concrete implementations
            IProxyHelper proxy = null;
            switch (proxyVersion)
            {
                case "1.0.0.0":
                    proxy = new ProxyHelperV4(apiInfo.Proxy);
                    break;

                default:
                    throw new NotSupportedException("Unknown API version detected. Plugin initialization unsuccessful.");
            }

            return proxy;
        }
    }
}

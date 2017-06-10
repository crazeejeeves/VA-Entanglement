using System;
using Xunit;
using Moq;

using entanglement.Core.Proxy;

namespace Core.Test
{
    public interface ICompatibleProxy
    {
        Version ProxyVersion { get; set; }
        Version VAVersion { get; set; }
    }

    public interface IIncompatibleProxy
    {
        string UnusedProperty { get; set; }
    }


    public class ApiInfoTest
    {
        [Fact]
        public void AcceptsAndReturnsVersionFromCompatibleDynamicType()
        {
            var mock = new Mock<ICompatibleProxy>();
            mock.SetupProperty(foo => foo.ProxyVersion, new Version(1, 2, 3, 4));
            mock.SetupProperty(foo => foo.VAVersion, new Version(1, 3, 3, 7));


            var apiInfo = new ApiInfo(mock.Object);

            Version expected = new Version(1, 2, 3, 4);
            Version actual = apiInfo.ProxyVersion;

            Assert.Equal(expected, actual);

            expected = new Version(1, 3, 3, 7);
            actual = apiInfo.VAVersion;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FailsWhenDynamicTypeSignatureMismatch()
        {
            var mock = new Mock<IIncompatibleProxy>();
            mock.SetupProperty(foo => foo.UnusedProperty, string.Empty);


            var apiInfo = new ApiInfo(mock.Object);

            Assert.Throws<Microsoft.CSharp.RuntimeBinder.RuntimeBinderException>(() => apiInfo.ProxyVersion);
            Assert.Throws<Microsoft.CSharp.RuntimeBinder.RuntimeBinderException>(() => apiInfo.VAVersion);
        }
    }

}

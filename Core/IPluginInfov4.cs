using System;

namespace entanglement.Core
{
    interface IPluginInfoV4
    {
        string Name         { get; }
        int    VersionMajor { get; }
        int    VersionMinor { get; }
        int    VersionPatch { get; }
        string DisplayName  { get; }
        string Description  { get; }
        Guid   ID           { get; }
    }

    struct PluginInfoV4
    {
        string Name         { get; set; }
        int    VersionMajor { get; set; }
        int    VersionMinor { get; set; }
        int    VersionPatch { get; set; }
        string Description  { get; set; }
        Guid   ID           { get; set; }
    }
}

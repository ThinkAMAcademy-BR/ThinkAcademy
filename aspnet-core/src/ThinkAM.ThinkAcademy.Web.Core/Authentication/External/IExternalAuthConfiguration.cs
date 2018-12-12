using System.Collections.Generic;

namespace ThinkAM.ThinkAcademy.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}

using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ThinkAM.ThinkAcademy.Configuration.Dto;

namespace ThinkAM.ThinkAcademy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ThinkAcademyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

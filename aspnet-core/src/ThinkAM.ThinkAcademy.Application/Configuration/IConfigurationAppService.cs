using System.Threading.Tasks;
using ThinkAM.ThinkAcademy.Configuration.Dto;

namespace ThinkAM.ThinkAcademy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

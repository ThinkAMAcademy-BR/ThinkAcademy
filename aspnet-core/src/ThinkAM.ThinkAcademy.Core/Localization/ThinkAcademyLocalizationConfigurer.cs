using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ThinkAM.ThinkAcademy.Localization
{
    public static class ThinkAcademyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ThinkAcademyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ThinkAcademyLocalizationConfigurer).GetAssembly(),
                        "ThinkAM.ThinkAcademy.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

// Generated by the Blazor I18n Text compiler
namespace MyBlazorApp.I18nText
{
    public partial class IndexResources : global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage, global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextLateBinding
    {
        string global::Toolbelt.Blazor.I18nText.Interfaces.I18nTextFallbackLanguage.FallBackLanguage => "en";

        public string this[string key] => global::Toolbelt.Blazor.I18nText.I18nTextExtensions.GetFieldValue(this, key);

        /// <summary>"Hello, world!"</summary>
        public string hello;

        /// <summary>"Show/Hide"</summary>
        public string showHide;

        /// <summary>"How is Blazor working for you?"</summary>
        public string surveyTitle;

        /// <summary>"Welcome to your new app."</summary>
        public string welcome;
    }
}

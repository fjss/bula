using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gar.Core.Managers
{
    public static class SettingsManager
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const string LocaleKey = "locale";
        private static readonly string LocaleDefault = "en";

        private const string LanguageKey = "language";
        private static readonly string LanguageDefault = "en";

        private const string TokenKey = "token";
        private static readonly string TokenDefault = string.Empty;

        public static string Locale
        {
            get => AppSettings.GetValueOrDefault(LocaleKey, LocaleDefault);
            set => AppSettings.AddOrUpdateValue(LocaleKey, value);
        }

        public static string Language
        {
            get => AppSettings.GetValueOrDefault(LanguageKey, LanguageDefault);
            set => AppSettings.AddOrUpdateValue(LanguageKey, value);
        }

        public static string Token
        {
            get => AppSettings.GetValueOrDefault(TokenKey, TokenDefault);
            set => AppSettings.AddOrUpdateValue(TokenKey, value);
        }

        public static void Logout()
        {
            CrossSettings.Current.Remove(TokenKey);
        }
    }
}

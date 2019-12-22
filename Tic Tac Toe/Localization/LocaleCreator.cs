using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Localization;

namespace Tic_Tac_Toe
{
    /// <summary>
    ///Localization creator class
    /// </summary>
    public static class LocaleCreator
    {
        /// <summary>
        /// Enum of interface languages
        /// </summary>
        public enum InterfaceLanguage
        {
            /// <summary>
            /// English locale
            /// </summary>
            en,
            /// <summary>
            /// Russian locale
            /// </summary>
            ru
        };
        /// <summary>
        /// Create locale method
        /// </summary>
        /// <param name="language">Language</param>
        /// <returns>Locale</returns>
        public static Locale CreateLocale(InterfaceLanguage language)
        {
            switch(language)
            {
                case InterfaceLanguage.en:
                    return new ENLocale();
                case InterfaceLanguage.ru:
                    return new RULocale();
            }
            return new ENLocale();
        }
    }
}

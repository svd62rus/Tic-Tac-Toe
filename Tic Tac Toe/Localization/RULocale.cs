using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Localization
{
    /// <summary>
    /// RU localization class
    /// </summary>
    public class RULocale : Locale, ILocalization
    {
        private readonly string mainMenuText = "Меню";
        private readonly string singlePlayerMenuText = "Новая игра";
        private readonly string lowDifficultText = "Легко";
        private readonly string hardDifficultText = "Сложно";
        private readonly string exitMenuText = "Выход";
        private readonly string scoreMenuText = "Счет";
        private readonly string difficultText = "Сложность";
        private readonly string currentDifficultText_Low = "легко";
        private readonly string currentDifficultText_Hard = "сложно";
        private readonly string playerText = "Текущий игрок";
        private readonly string botNameText = "Компьютер";
        private readonly string drawText = "Ничья...";
        private readonly string winText = " выиграл!";
        private readonly string impossibleStepText = "Такой ход невозможен!";
        private readonly string savesSavingErrorText = "Ошибка сохранения в файл! Счет будет сброшен.";
        private readonly string savesLoadingErrorText = "Ошибка загрузки файла сохранения! Счет будет сброшен.";
        private readonly string errorText = "Ошибка!";
        private readonly string profileText = "Профиль";
        private readonly string winCountText = "Выйгрыши";
        private readonly string loseCountText = "Проигрыши";
        private readonly string drawCountText = "Ничьи";
        private readonly string inputPlayerNameText = "Введите имя игрока:";
        private readonly string createPlayerButtonText = "Создать профиль";
        /// <summary>
        /// Constructor of russian locale
        /// </summary>
        public RULocale()
        {
            localeDict[LocaleIds.MainMenuID] = mainMenuText;
            localeDict[LocaleIds.SinglePlayerMenuID] = singlePlayerMenuText;
            localeDict[LocaleIds.LowDifficultID] = lowDifficultText;
            localeDict[LocaleIds.HardDifficultID] = hardDifficultText;
            localeDict[LocaleIds.ExitMenuID] = exitMenuText;
            localeDict[LocaleIds.ScoreMenuID] = scoreMenuText;
            localeDict[LocaleIds.DifficultTextID] = difficultText;
            localeDict[LocaleIds.CurrentGameLowDifficultID] = currentDifficultText_Low;
            localeDict[LocaleIds.CurrentGameHardDifficultID] = currentDifficultText_Hard;
            localeDict[LocaleIds.PlayerTextID] = playerText;
            localeDict[LocaleIds.BotNameID] = botNameText;
            localeDict[LocaleIds.DrawTextID] = drawText;
            localeDict[LocaleIds.WinTextID] = winText;
            localeDict[LocaleIds.ImpossibleStepTextID] = impossibleStepText;
            localeDict[LocaleIds.SavesSavingErrorID] = savesSavingErrorText;
            localeDict[LocaleIds.SavesLoadingErrorID] = savesLoadingErrorText;
            localeDict[LocaleIds.ErrorID] = errorText;
            localeDict[LocaleIds.ProfileID] = profileText;
            localeDict[LocaleIds.WinsCountID] = winCountText;
            localeDict[LocaleIds.LosesCountID] = loseCountText ;
            localeDict[LocaleIds.DrawCountID] = drawCountText;
            localeDict[LocaleIds.InputProfileNameID] = inputPlayerNameText;
            localeDict[LocaleIds.CreateProfileButtonNameID] = createPlayerButtonText;
            Localization = LocaleCreator.InterfaceLanguage.ru;
        }
    }
}

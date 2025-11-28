using System.Collections.Generic;
using System.Linq;

namespace CivVIDrafter
{
    public static class CivilizationList
    {
        /// <summary>
        /// Полный список всех цивилизаций и лидеров.
        /// </summary>
        public static readonly List<Civilization> AllCivilizations = new List<Civilization>
        {
            // Vanilla
            new Civilization("Англия", "Виктория", DLC.Vanilla),
            new Civilization("Франция", "Екатерина Медичи (Черная королева)", DLC.Vanilla),
            new Civilization("Рим", "Троян", DLC.Vanilla),
            new Civilization("Германия", "Фридрих Барбаросса", DLC.Vanilla),
            new Civilization("Америка", "Теодор Рузвельт (Прогрессивист)", DLC.Vanilla),
            new Civilization("Индия", "Ганди", DLC.Vanilla),
            new Civilization("Скифия", "Томирис", DLC.Vanilla),
            new Civilization("Греция", "Перикл", DLC.Vanilla),
            new Civilization("Греция", "Горго", DLC.Vanilla),
            new Civilization("Китай", "Цинь Шихуанди (Небесный мандат)", DLC.Vanilla),
            new Civilization("Египет", "Клеопатра (Царица Нила)", DLC.Vanilla),
            new Civilization("Россия", "Петр I", DLC.Vanilla),
            new Civilization("Ацтеки", "Монтесума", DLC.Vanilla),
            new Civilization("Бразилия", "Педро II", DLC.Vanilla),
            new Civilization("Испания", "Филипп II", DLC.Vanilla),
            new Civilization("Конго", "Мвемба а Нзинга", DLC.Vanilla),
            new Civilization("Аравия", "Саладин (Визирь)", DLC.Vanilla),
            new Civilization("Норвегия", "Харльд III Суровый (Конунг)", DLC.Vanilla),
            new Civilization("Шумеры", "Гильгамеш", DLC.Vanilla),
            new Civilization("Япония", "Ходзе Токимуне", DLC.Vanilla),
            new Civilization("Рим", "Цезарь", DLC.Vanilla),

            // Scenario Packs
            new Civilization("Австралия", "Джон Кертин", DLC.ScenarioPacks),
            new Civilization("Польша", "Ядвига", DLC.ScenarioPacks),
            new Civilization("Персия", "Кир", DLC.ScenarioPacks),
            new Civilization("Македония", "Александр", DLC.ScenarioPacks),
            new Civilization("Нубия", "Аманиторе", DLC.ScenarioPacks),
            new Civilization("Индонезия", "Трибхувана", DLC.ScenarioPacks),
            new Civilization("Кхмеры", "Джайаварман VII", DLC.ScenarioPacks),

            // Gathering Storm
            new Civilization("Венгрия", "Матьяш I", DLC.GatheringStorm),
            new Civilization("Маори", "Купе", DLC.GatheringStorm),
            new Civilization("Канада", "Уилфрид Лорье", DLC.GatheringStorm),
            new Civilization("Инки", "Пачакутек", DLC.GatheringStorm),
            new Civilization("Мали", "Манса Мунса", DLC.GatheringStorm),
            new Civilization("Швеция", "Кристина", DLC.GatheringStorm),
            new Civilization("Османская империя", "Сулейман (Кануни)", DLC.GatheringStorm),
            new Civilization("Финикия", "Дидона", DLC.GatheringStorm),
            new Civilization("Франция", "Алиенора Аквитанская", DLC.GatheringStorm),
            new Civilization("Англия", "Алиенора Аквитанская", DLC.GatheringStorm),

            // Rise and Fall
            new Civilization("Индия", "Чандрагупта", DLC.RiseAndFall),
            new Civilization("Корея", "Сондок", DLC.RiseAndFall),
            new Civilization("Нидерланды", "Вильгельмина", DLC.RiseAndFall),
            new Civilization("Монголия", "Чингисхан", DLC.RiseAndFall),
            new Civilization("Кри", "Паундмейкер", DLC.RiseAndFall),
            new Civilization("Грузия", "Тамара", DLC.RiseAndFall),
            new Civilization("Шотландия", "Роберт Брюс", DLC.RiseAndFall),
            new Civilization("Мапуче", "Лаутаро", DLC.RiseAndFall),
            new Civilization("Зулусы", "Чака", DLC.RiseAndFall),

            // New Frontier Pass
            new Civilization("Майя", "Иш-Вак-Чан-Ахав", DLC.NewFrontierPass),
            new Civilization("Колумбия", "Симон Боливар", DLC.NewFrontierPass),
            new Civilization("Эфиопия", "Менелик II", DLC.NewFrontierPass),
            new Civilization("Византия", "Василий II", DLC.NewFrontierPass),
            new Civilization("Галия", "Амбиорикс", DLC.NewFrontierPass),
            new Civilization("Вавилон", "Хаммурапи", DLC.NewFrontierPass),
            new Civilization("Вьетнам", "Чьеу Тхи Чинь", DLC.NewFrontierPass),
            new Civilization("Китай", "Хубилай (Император Китая)", DLC.NewFrontierPass),
            new Civilization("Монголия", "Хубилай (Великий Хан)", DLC.NewFrontierPass),
            new Civilization("Португалия", "Жуан III", DLC.NewFrontierPass),

            // Leader Pass
            new Civilization("Америка", "Авраам Линкольн", DLC.LeaderPass),
            new Civilization("Конго", "Н'Зинга Мбанди", DLC.LeaderPass),
            new Civilization("Аравия", "Саладин (Султан)", DLC.LeaderPass),
            new Civilization("Япония", "Токугава", DLC.LeaderPass),
            new Civilization("Персия", "Надир-шах", DLC.LeaderPass),
            new Civilization("Османская империя", "Сулейман (Великолепный)", DLC.LeaderPass),
            new Civilization("Китай", "Юнлэ", DLC.LeaderPass),
            new Civilization("Китай", "Цинь Шихуанди (Первый император)", DLC.LeaderPass),
            new Civilization("Китай", "У Цзэтянь", DLC.LeaderPass),
            new Civilization("Египет", "Рамзес II", DLC.LeaderPass),
            new Civilization("Египет", "Клеопатра (Птолемейская)", DLC.LeaderPass),
            new Civilization("Мали", "Сундиата Кейта", DLC.LeaderPass),
            new Civilization("Византия", "Феодора", DLC.LeaderPass),
            new Civilization("Корея", "Седжон", DLC.LeaderPass),
            new Civilization("Германия", "Людвиг II", DLC.LeaderPass),
            new Civilization("Англия", "Елизавета I", DLC.LeaderPass),
            new Civilization("Англия", "Виктория (Эпоха паровых машин)", DLC.LeaderPass),
            new Civilization("Норвегия", "Харльд III Суровый (Варяг)", DLC.LeaderPass)
        };

        /// <summary>
        /// Получить список цивилизаций по выбранным DLC.
        /// </summary>
        public static IEnumerable<Civilization> GetByDLC(DLC dlcMask)
        {
            return AllCivilizations.Where(c => dlcMask.HasFlag(c.Pack));
        }
    }
}

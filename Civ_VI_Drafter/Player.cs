using System;
using System.Collections.Generic;
using System.Linq;

namespace CivVIDrafter
{
    public class Player
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Никнейм игрока (если пустой, будет "Player{id}").
        /// </summary>
        public string NickName { get; }

        /// <summary>
        /// Уникальный идентификатор игрока.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Включённые DLC для этого игрока.
        /// </summary>
        public DLC EnabledDLC { get; }

        /// <summary>
        /// Список доступных цивилизаций для выбора.
        /// </summary>
        public List<Civilization> AvailableCivs { get; private set; }

        /// <summary>
        /// Список уже выбранных (рандомных) цивилизаций.
        /// </summary>
        public List<Civilization> DraftedCivs { get; private set; }

        /// <summary>
        /// Конструктор игрока.
        /// </summary>
        public Player(string nickName, int id, DLC enabledDLC, List<Civilization> exceptions = null)
        {
            NickName = string.IsNullOrWhiteSpace(nickName) ? $"Player{id}" : nickName;
            Id = id;
            EnabledDLC = enabledDLC;

            // Получаем список цивилизаций по выбранным DLC
            AvailableCivs = CivilizationList.GetByDLC(enabledDLC).ToList();

            // Убираем исключения, если они есть
            if (exceptions != null && exceptions.Any())
                AvailableCivs.RemoveAll(c => exceptions.Contains(c));

            DraftedCivs = new List<Civilization>();
        }

        /// <summary>
        /// Количество доступных цивилизаций.
        /// </summary>
        public int GetAvailableCivsCount() => AvailableCivs.Count;

        /// <summary>
        /// Случайный выбор цивилизаций для игрока.
        /// </summary>
        public void DraftCivs(int count)
        {
            if (count > AvailableCivs.Count)
                throw new InvalidOperationException("Недостаточно цивилизаций для драфта!");

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(AvailableCivs.Count);
                var civ = AvailableCivs[index];
                DraftedCivs.Add(civ);
                AvailableCivs.RemoveAt(index);
            }
        }

        /// <summary>
        /// Красивый вывод информации об игроке и его цивилизациях.
        /// </summary>
        public override string ToString()
        {
            var civs = string.Join(Environment.NewLine, DraftedCivs.Select(c => c.ToString()));
            return $"{NickName}:\n{civs}\n";
        }
    }
}

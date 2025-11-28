using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CivVIDrafter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик кнопки "Сделать драфт".
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var playersList = new List<Player>();
            var exceptionCivs = new List<Civilization>();

            int numPlayers = (int)sliderNumPlayers.Value;
            int numCivs = (int)sliderNumCivs.Value;

            // Никнеймы игроков
            string[] nickNames = { tb1.Text, tb2.Text, tb3.Text, tb4.Text,
                                   tb5.Text, tb6.Text, tb7.Text, tb8.Text };

            // DLC для каждого игрока
            DLC[] dlcSelections = new DLC[8];
            dlcSelections[0] = GetPlayerDLC(cb1_Scenario, cb1_Gathering, cb1_Rise, cb1_Frontier, cb1_Leader);
            dlcSelections[1] = GetPlayerDLC(cb2_Scenario, cb2_Gathering, cb2_Rise, cb2_Frontier, cb2_Leader);
            dlcSelections[2] = GetPlayerDLC(cb3_Scenario, cb3_Gathering, cb3_Rise, cb3_Frontier, cb3_Leader);
            dlcSelections[3] = GetPlayerDLC(cb4_Scenario, cb4_Gathering, cb4_Rise, cb4_Frontier, cb4_Leader);
            dlcSelections[4] = GetPlayerDLC(cb5_Scenario, cb5_Gathering, cb5_Rise, cb5_Frontier, cb5_Leader);
            dlcSelections[5] = GetPlayerDLC(cb6_Scenario, cb6_Gathering, cb6_Rise, cb6_Frontier, cb6_Leader);
            dlcSelections[6] = GetPlayerDLC(cb7_Scenario, cb7_Gathering, cb7_Rise, cb7_Frontier, cb7_Leader);
            dlcSelections[7] = GetPlayerDLC(cb8_Scenario, cb8_Gathering, cb8_Rise, cb8_Frontier, cb8_Leader);

            // Формируем игроков
            for (int i = 0; i < numPlayers; i++)
            {
                var player = new Player(nickNames[i], i + 1, dlcSelections[i], exceptionCivs);

                if (numCivs > player.GetAvailableCivsCount())
                {
                    MessageBox.Show("Недостаточно цивилизаций для текущих настроек!", "Ошибка",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                player.DraftCivs(numCivs);
                exceptionCivs.AddRange(player.DraftedCivs);
                playersList.Add(player);
            }

            // Выводим результат
            var msg = new StringBuilder();
            foreach (var player in playersList)
            {
                msg.AppendLine(player.ToString());
            }

            MessageBox.Show(msg.ToString(), "Драфты", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Собирает выбранные DLC для игрока.
        /// </summary>
        private DLC GetPlayerDLC(params CheckBox[] checkBoxes)
        {
            DLC dlc = DLC.Vanilla; // базовая игра всегда включена
            if (checkBoxes[0].IsChecked == true) dlc |= DLC.ScenarioPacks;
            if (checkBoxes[1].IsChecked == true) dlc |= DLC.GatheringStorm;
            if (checkBoxes[2].IsChecked == true) dlc |= DLC.RiseAndFall;
            if (checkBoxes[3].IsChecked == true) dlc |= DLC.NewFrontierPass;
            if (checkBoxes[4].IsChecked == true) dlc |= DLC.LeaderPass;
            return dlc;
        }

        /// <summary>
        /// Управляет видимостью блоков игроков при изменении слайдера.
        /// </summary>
        private void sliderNumPlayers_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!IsLoaded) return; // защита от вызова при инициализации

            int playersCount = (int)e.NewValue;

            Grid[] playerGrids = { player1Grid, player2Grid, player3Grid, player4Grid,
                           player5Grid, player6Grid, player7Grid, player8Grid };

            for (int i = 0; i < playerGrids.Length; i++)
            {
                playerGrids[i].Visibility = i < playersCount ? Visibility.Visible : Visibility.Collapsed;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockPaperScissors_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameStates.States compStates;
        private GameStates.States playerStates;
        public MainWindow()
        {
            InitializeComponent();
            compStates = new GameStates.States();
            playerStates = new GameStates.States();
            btnRock.Click += BtnRock_Click;
            btnScissors.Click += BtnScissors_Click;
            btnPaper.Click += BtnPaper_Click;            
        }

        private void BtnRock_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Камень"
            txtResult.Text += "Вы выбрали Камень\n";
            playerStates = GameStates.States.Камень;
            compStates = GameStates.GetRandomState();
            GameHandler();
        }

        private void BtnScissors_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Ножницы"
            txtResult.Text += "Вы выбрали Ножницы\n";
            playerStates = GameStates.States.Ножницы;
            compStates = GameStates.GetRandomState();
            GameHandler();
        }

        private void BtnPaper_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Бумага"
            txtResult.Text += "Вы выбрали Бумагу\n";
            playerStates = GameStates.States.Бумага;
            compStates = GameStates.GetRandomState();
            GameHandler();
        }

        private void GameHandler()
        {            
                txtResult.Text += $"Компьютер выбрал {compStates}\n";
                int rezult = GameStates.Comparer.Compare(playerStates, compStates);
                if (rezult == 1)
                {
                    txtResult.Text += "Вы победили!\n";

                }
                else if (rezult == 0)
                {
                    txtResult.Text += "У вас ничья!\n";
                }
                else
                {
                    txtResult.Text += "Вы проиграли! \n";
                }            
        }       
    }
}


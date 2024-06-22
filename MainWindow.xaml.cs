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
        public MainWindow()
        {
            InitializeComponent();
            btnRock.Click += BtnRock_Click;
            btnScissors.Click += BtnScissors_Click;
            btnPaper.Click += BtnPaper_Click;
            btnStartGame.Click += BtnStartGame_Click;
        }

        private void BtnRock_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Камень"
            txtResult.Text += "Выбран Камень\n";
        }

        private void BtnScissors_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Ножницы"
            txtResult.Text += "Выбраны Ножницы\n";
        }

        private void BtnPaper_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Бумага"
            txtResult.Text += "Выбрана Бумага\n";
        }

        private void BtnStartGame_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Начать игру"
            txtResult.Text += "Игра началась!\n";
        }
    }
}


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

namespace Riddle_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;

        int i;

        int score;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {

        }

        private void RestartGame()
        {

        }

        private void NextQuestion()
        {

        }

        private void StartGame()
        {

        }
    }
}

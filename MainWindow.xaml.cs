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
            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Corectly" + score + "/" + questionNumbers.Count;
            
            NextQuestion();

        }

        private void RestartGame()
        {
            score = 0;
            qNum = 1;
            i = 0;
            StartGame();

        }

        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }


            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i)
            {

                case 1:

                    txtQuestion.Text = "What has to be broken before you can use it?";

                    ans1.Content = "Remote";
                    ans2.Content = "Egg";
                    ans3.Content = "Glow Stick";
                    ans4.Content = "Wrapper";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 2:

                    txtQuestion.Text = "What jumps when it walks and sit when its standing?";

                    ans1.Content = "Spider";
                    ans2.Content = "Frog";
                    ans3.Content = "Rabbit";
                    ans4.Content = "Kangaroo";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 3:

                    txtQuestion.Text = "What can run but not walk?";

                    ans1.Content = "A Baby";
                    ans2.Content = "River";
                    ans3.Content = "Monkey";
                    ans4.Content = "Radio";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 4:

                    txtQuestion.Text = "What can you catch but not throw?";

                    ans1.Content = "Ball";
                    ans2.Content = "Fish";
                    ans3.Content = "Cold";
                    ans4.Content = "Dandelion";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 5:

                    txtQuestion.Text = "What kind of band never plays music";

                    ans1.Content = "Acoustic Band";
                    ans2.Content = "Rap Band";
                    ans3.Content = "Rubberband";
                    ans4.Content = "None of the above";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 6:

                    txtQuestion.Text = "What has a neck but no head?";

                    ans1.Content = "Bottle";
                    ans2.Content = "Shadow";
                    ans3.Content = "Tree";
                    ans4.Content = "Worm";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 7:

                    txtQuestion.Text = "He is a man during the winter, but you might drink him in the summer";

                    ans1.Content = "Iceman";
                    ans2.Content = "Jim";
                    ans3.Content = "Jack";
                    ans4.Content = "Frosty";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 8:

                    txtQuestion.Text = "I have no life, but I can die";

                    ans1.Content = "Battery";
                    ans2.Content = "Time";
                    ans3.Content = "Daylight";
                    ans4.Content = "Sound";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 9:

                    txtQuestion.Text = "When the water comes down, when it rains, I go up. What am I?";

                    ans1.Content = "River";
                    ans2.Content = "Umbrella";
                    ans3.Content = "Window";
                    ans4.Content = "Temperature";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;

                case 10:

                    txtQuestion.Text = "What month of the year has 28 days?";

                    ans1.Content = "February";
                    ans2.Content = "December";
                    ans3.Content = "All of them";
                    ans4.Content = "June";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/game.png"));

                    break;




            }

        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrder.Content = null;

            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }
    }
}

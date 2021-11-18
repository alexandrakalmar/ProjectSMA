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

namespace interractive_dictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int qNum = 0, i, score;


        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        private void CheckAnswear(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if(senderButton.Tag.ToString() == "1")   //our Tag is on 0 => score++
            {
                score++;
            }
            if(qNum < 0) //if we have no questions => we will put qNum on 0
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;
            NextQuestion(); //we are moving forward to the next question
        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        private void NextQuestion()
        {
            if(qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }
            
            foreach(var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.YellowGreen;
            }

            switch(i)
            {
                case 1:
                    txtQestion.Text = "question 1";
                    answear1.Content = "answear 1";
                    answear2.Content = "answear 2";
                    answear3.Content = "answear 3";
                    answear4.Content = "answear 4";

                    answear2.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\Users\Alexandra\source\repos\interractive_dictionary\images\brioche.jpg"))
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;
            }
        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = randomList;
            questionOrder.Content = null;
            for(int i = 0; i <questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }
    }



}

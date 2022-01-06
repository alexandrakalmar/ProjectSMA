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
        int qNum = 0; //will control each question which will be shown on the screen
        int i;        //index for each question
        int score;    //score after the answers 



        public MainWindow()  //in the constructor class we will call these 3 methods
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        private void CheckAnswear(object sender, RoutedEventArgs e) //this event in linked to each button on the Canvas
        //this event will be runned when either of the buttons will be pressed
        {
            Button senderButton = sender as Button; //first we check which button have sent this event
            //it will be linked to a local button inside of this event
            if(senderButton.Tag.ToString() == "1")   
            {
                score++; //if the tag will be set on 1(which means that the answer is correct) -> score++
            }
            if(qNum < 0) //if we have no questions => we will put qNum on 0
            {
                qNum = 0;
            }
            else
            {
                qNum++;  //each time the button will be pressed, the number of questions will be increased
            }
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;
            NextQuestion(); //we are moving forward to the next question
        }

        private void RestartGame()
        {
            score = 0;
            qNum = -1; //it will be incremented whenever it starts => the player needs to double click to start the game again
            i = 0;
            StartGame();
        }

        private void NextQuestion()
        {
            if(qNum < questionNumbers.Count) //we check if the qnub is less then the total number of questions 
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }
            
            //here we check for each button in Canvas => when we will find the buttons, we will put them on tag 0 by default
            foreach(var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";  //each button will have the tag 0
                x.Background = Brushes.YellowGreen; //set the color for each button 
            }

            switch(i)  //i represents the question number 
            {
                case 1:
                    txtQuestion.Text = "Definition of a Brioche : ";

                    answear1.Content = "just bread";
                    answear2.Content = "light slightly sweet bread made with a rich yeast dough";
                    answear3.Content = "a fish";
                    answear4.Content = "something sweet which looks like a normal bread";

                    answear2.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\brioche.jpg"));
                   
                    break;

                case 2:
                    txtQuestion.Text = "What is a Ciabatta?";

                    answear1.Content = "a flat oblong bread having a moist interior and a crispy crust";
                    answear2.Content = "a crispy strips";
                    answear3.Content = "a normal bread";
                    answear4.Content = "a fruit";

                    answear1.Tag = "1"; //the correct answear 
                    //when the correct button will be clicked, then we add 1 to the score 
                    //if the correct button will be not selected, then we will go to the next question

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\ciabatta.jpg"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;

                case 3:
                    txtQuestion.Text = "Describe what is a dictionary : ";

                    answear1.Content = "a driving licence";
                    answear2.Content = "a passport";
                    answear3.Content = "a reference book";
                    answear4.Content = "an onion";

                    answear3.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\dictionary.jpg"));
                    break;

                case 4:
                    txtQuestion.Text = "Description of an espresso : ";

                    answear1.Content = "an animal";
                    answear2.Content = "a book";
                    answear3.Content = "a wine";
                    answear4.Content = "coffee brewed";

                    answear4.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\espresso.jpg"));
                    break;

                case 5:
                    txtQuestion.Text = "What are headphones?";

                    answear1.Content = "an earphone held over the ear";
                    answear2.Content = "a glass of water";
                    answear3.Content = "a crystal";
                    answear4.Content = "a smartphone";

                    answear1.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\headphones.jpg"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;

                case 6:
                    txtQuestion.Text = "Define scissors : ";

                    answear1.Content = "a sport";
                    answear2.Content = "a cutting instrument";
                    answear3.Content = "a mobile phone";
                    answear4.Content = "a chicken";

                    answear2.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\scissors.jpg"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;

                case 7:
                    txtQuestion.Text = "Describe a squirrel : ";

                    answear1.Content = "a vaccine";
                    answear2.Content = "a pair of jeans";
                    answear3.Content = "small or medium-sized rodents";
                    answear4.Content = "something sweet";

                    answear3.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\squirrel.jpg"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;

                case 8:
                    txtQuestion.Text = "What is a glass?";

                    answear1.Content = "a pair of shoes";
                    answear2.Content = "s crystal";
                    answear3.Content = "food";
                    answear4.Content = "a usually transparent or translucent material";

                    answear4.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\glass.jfif"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;

                case 9:
                    txtQuestion.Text = "Definiton of a cigarette ";

                    answear1.Content = "a cake";
                    answear2.Content = "a library";
                    answear3.Content = "a slender roll of cut tobacco enclosed in paper";
                    answear4.Content = "a coffee";

                    answear3.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\cigarette.jfif"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;

                case 10:
                    txtQuestion.Text = "What are fireworks?";

                    answear1.Content = "a device for producing a striking display";
                    answear2.Content = "an animal";
                    answear3.Content = "a dog";
                    answear4.Content = "sa pet";

                    answear1.Tag = "1"; //the correct answear 

                    qImage.Source = new BitmapImage(new Uri("C:\\Users\\Alexandra\\source\\repos\\interractive_dictionary\\images\\fireworks.jfif"));
                    //qImage.Source = new BitmapImage(new Uri("pack://application:,,,/brioche.jpg"));
                    break;



            }
        }

        private void StartGame()
        {
            //randomise the order of the content with a randomlist variable
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList(); //it converts whatever it finds into a random list
            questionNumbers = randomList; //save the randomlist to the questionNumber list again
            questionOrder.Content = null; //empty the question order on the Canvas
            for(int i = 0; i <questionNumbers.Count; i++)
            {
                //display the randomised list
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }
    }



}

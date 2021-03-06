﻿using System;
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
using System.Windows.Shapes;

namespace Learning
{
    /// <summary>
    /// Interaction logic for Animals.xaml
    /// </summary>
    public partial class Animals : Window
    {
         question_facade questions = new question_facade();

        public Animals()
        {
            InitializeComponent();
            questions.A_questions();
            
            
        }
   
        List<string> question = new List<string>() { "one","two","three","four","five","six","seven","eight","nine","ten" };
        List<int> answered = new List<int>();
        string answer,Your_answer,q;
        int picture,score = 0;
        Random random = new Random();

        private void randomize_picture()
        {
            if (questions.animal_q.Count == 0)
            {
                MessageBox.Show("All questions have been answered");
                btnOK.IsEnabled = false;

            }
            else
            {
                int index = random.Next(question.Count);
                q = question[index];



                foreach (Animal_questions a in questions.animal_q)
                {
                    if (q == a.Q_number)
                    {
                        lblanswer.Content = a.Animal_answers;
                        lblQuestion.Content = a.Animal_Name;
                        imgQuestiion.Source = new BitmapImage(new Uri(a.Img_Source));
                        imgQuestiion.ClipToBounds = true;
                        imgQuestiion.Height = 250;
                        imgQuestiion.Width = 350;
                        questions.animal_q.Remove(a);
                        //answered.Add(picture);
                        question.RemoveAt(index);
                        break;
                    }
                }
            }
           
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            
            Your_answer = txtAnswer.Text;
            Your_answer = Your_answer.ToLower();
            answer = lblanswer.Content.ToString();
            if (answer == Your_answer)
            {
                score= score + 1;
                lblScore.Content =("Your score is " + score);
                
            }
            else
            {
                MessageBox.Show("Sorry, your answer is wrong \nThe correct answer was "+lblanswer.Content);
            }
            txtAnswer.Clear();
            randomize_picture();
        }

        private void btnbegin_Click(object sender, RoutedEventArgs e)
        {
            cvsbegin.Visibility = Visibility.Hidden;
            randomize_picture();
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to quit","Exit",MessageBoxButton.YesNo,MessageBoxImage.Stop,MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Your score was " + score);
                this.Close();
            }
            else
            {
                MessageBox.Show("Your score was " + score
                     + "\nThanks for playing");
            }
        }

        
    }
}

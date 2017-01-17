using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class question_facade
    {
        public List<Animal_questions> animal_q = new List<Animal_questions>();
        public List<Food_questions> food_q = new List<Food_questions>(); 

        public void A_questions()
        {
            Animal_questions one = new Animal_questions();
            one.Q_number = "one";
            one.Animal_Name = "Zebra";
            one.Animal_answers = "punda milia";
            one.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\zebra.jpg";
            animal_q.Add(one);
            
            Animal_questions two = new Animal_questions();
            two.Q_number = "two";
            two.Animal_Name = "Elephant";
            two.Animal_answers = "tembo";
            two.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\elephant.jpg";
            animal_q.Add(two);

            Animal_questions three = new Animal_questions();
            three.Q_number = "three";
            three.Animal_Name = "Lion";
            three.Animal_answers = "simba";
            three.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\lion.jpg";
            animal_q.Add(three);

            Animal_questions four = new Animal_questions();
            four.Q_number = "four";
            four.Animal_Name = "Vervet Monkey";
            four.Animal_answers = "tumbili";
            four.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\vervet.jpg";
            animal_q.Add(four);

            Animal_questions five = new Animal_questions();
            five.Q_number = "five";
            five.Animal_Name = "Cheetah";
            five.Animal_answers = "duma";
            five.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\cheetah.jpg";
            animal_q.Add(five);

            Animal_questions six = new Animal_questions();
            six.Q_number = "six";
            six.Animal_Name = "Rhino";
            six.Animal_answers = "kifaru";
            six.Img_Source = @"H:\Visual Studio 2013\ProjectsLearning\Images\Animals\rhino.jpg";
            animal_q.Add(six);

            Animal_questions seven = new Animal_questions();
            seven.Q_number = "seven";
            seven.Animal_Name = "Giraff";
            seven.Animal_answers = "twiga";
            seven.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\giraff.jpg";
            animal_q.Add(seven);

            Animal_questions eight = new Animal_questions();
            eight.Q_number = "eight";
            eight.Animal_Name = "Hippo";
            eight.Animal_answers = "kiboko";
            eight.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\hippo.jpg";
            animal_q.Add(eight);

            Animal_questions nine = new Animal_questions();
            nine.Q_number ="nine" ;
            nine.Animal_Name = "Hyena";
            nine.Animal_answers = "fisi";
            nine.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\hyena.jpg";
            animal_q.Add(nine);

            Animal_questions ten = new Animal_questions();
            ten.Q_number = "ten";
            ten.Animal_Name ="Leopard" ;
            ten.Animal_answers = "chui";
            ten.Img_Source = @"H:\Visual Studio 2013\Projects\Learning\Images\Animals\leopard.jpg";
            animal_q.Add(ten);

            
        }
    
        public void F_questions()
        {
            Food_questions one = new Food_questions();
            one.Question_no = "one";
            one.Food_Name = "Pasta";
            one.Food_Answer = "tambi";
            one.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\pasta.jpg";
            food_q.Add(one);

            Food_questions two = new Food_questions();
            two.Question_no = "two";
            two.Food_Name = "Banana";
            two.Food_Answer = "ndizi";
            two.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\banana.jpg";
            food_q.Add(two);

            Food_questions three = new Food_questions();
            three.Question_no = "three";
            three.Food_Name = "Water";
            three.Food_Answer = "maji";
            three.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\water.jpg";
            food_q.Add(three);

            Food_questions four = new Food_questions();
            four.Question_no = "four";
            four.Food_Name = "Chicken";
            four.Food_Answer = "kuku";
            four.Food_Image = @"H:\Visual Studio 2013\ProjectsLearning\Images\Food\chicken.jpg";
            food_q.Add(four);

            Food_questions five = new Food_questions();
            five.Question_no = "five";
            five.Food_Name = "Fish";
            five.Food_Answer = "Samaki";
            five.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\fish.jpg";
            food_q.Add(five);

            Food_questions six = new Food_questions();
            six.Question_no = "six";
            six.Food_Name = "Salad";
            six.Food_Answer = "saladi";
            six.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\salad.jpg";
            food_q.Add(six);

            Food_questions seven = new Food_questions();
            seven.Question_no = "seven";
            seven.Food_Name = "Bread";
            seven.Food_Answer = "mkate";
            seven.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\bread.jpg";
            food_q.Add(seven);

            Food_questions eight = new Food_questions();
            eight.Question_no = "eight";
            eight.Food_Name = "Cooked Rice";
            eight.Food_Answer = "wali";
            eight.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\rice.jpg";
            food_q.Add(eight);

            Food_questions nine = new Food_questions();
            nine.Question_no = "nine";
            nine.Food_Name = "Tea";
            nine.Food_Answer = "chai";
            nine.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\tea.jpg";
            food_q.Add(nine);

            Food_questions ten = new Food_questions();
            ten.Question_no = "ten";
            ten.Food_Name = "Salt";
            ten.Food_Answer = "chumvi";
            ten.Food_Image = @"H:\Visual Studio 2013\Projects\Learning\Images\Food\salt.jpg";
            food_q.Add(ten);

        }
    }
}

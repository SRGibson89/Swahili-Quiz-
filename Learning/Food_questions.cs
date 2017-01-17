using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Food_questions
    {
        private string question_no, food_name, food_answer, food_image;

        public string Question_no
        {
            get { return question_no; }
            set { question_no = value; }
        }

        public string Food_Name
        {
            get { return food_name; }
            set { food_name = value; }
        }

        public string Food_Answer
        {
            get { return food_answer; }
            set { food_answer = value; }
        }

        public string Food_Image
        {
            get { return food_image; }
            set { food_image = value; }
        }
    }
}

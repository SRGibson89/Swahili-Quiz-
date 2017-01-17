using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Animal_questions
    {
        private string animal_name, animal_answer, img_source;
        private string q_number;
        
        public string Animal_Name
        {
            get { return animal_name; }
            set { animal_name = value; }
        }

        public string Animal_answers
        {
            get { return animal_answer; }
            set { animal_answer = value; }
        }

        public string Img_Source
        {
            get { return img_source; }
            set { img_source = value; }
        }

        public string Q_number
        {
            get { return q_number; }
            set { q_number = value; }
        }
    }
}
